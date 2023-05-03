using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Tut.Model.SiteDbContext;
using TutApp.Core.Configurations;
using TutApp.Core.Contracts;
using TutApp.Core.Repository;
using TutApp.Data.Models;

var builder = WebApplication.CreateBuilder(args);

#region Add Services

// DbContextFactory
var connectionString = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContextFactory<SiteDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

// AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

// OData
builder.Services.AddControllers().AddOData(options =>
{
    options.Select().Filter().OrderBy();
});

// Repository Pattern
builder.Services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

// IdentityCore
builder.Services.AddIdentityCore<User>()
                .AddRoles<IdentityRole>()
                .AddTokenProvider<DataProtectorTokenProvider<User>>("TutApi")
                .AddEntityFrameworkStores<SiteDbContext>()
                .AddDefaultTokenProviders();

// Controllers
builder.Services.AddControllers();

// JwtBearer
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; // "Bearer"
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; // "Bearer"
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes(builder.Configuration["Keys:Key"]!))
    };
});

// CORS
builder.Services.AddCors(x => x.AddPolicy(
    "myPolicy", c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
    )
);

#endregion Add Services

var app = builder.Build();

#region HTTP Request Pipeline

app.UseHttpsRedirection();

app.UseCors("myPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

#endregion HTTP Request Pipeline

app.Run();
