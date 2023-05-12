using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Tut.Data.SiteDbContext;
using TutApp.Api.Controllers;
using TutApp.Api.Middleware;
using TutApp.Core.Configurations;
using TutApp.Core.Contracts;
using TutApp.Core.Repository;
using TutApp.Data.Models;

var builder = WebApplication.CreateBuilder(args);

#region Add Services

// DbContext
string? GetConnectionString() => builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<SiteDbContext>(options =>
{
    options.UseSqlServer(GetConnectionString());
});

// IdentityCore
builder.Services.AddIdentityCore<User>()
                .AddRoles<IdentityRole>()
                .AddTokenProvider<DataProtectorTokenProvider<User>>("TutApi")
                .AddEntityFrameworkStores<SiteDbContext>()
                .AddDefaultTokenProviders();

// Swager (Authentication implemented in Swagger)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TutApi",
        Version = "v1"
    });
    options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using Bearer scheme.
                        Enter 'Bearer' [space] and your token in the text input below.
                        Exapmle: 'Bearer 1234abcdeFg'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = JwtBearerDefaults.AuthenticationScheme
                },
                Scheme = "0auth2",
                Name = JwtBearerDefaults.AuthenticationScheme,
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

// CORS
builder.Services.AddCors(options => options.AddPolicy(
    "myPolicy", c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin())
);

// Versioning
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Version"),
        new MediaTypeApiVersionReader("ver")
    );
});
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

// Repository
builder.Services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IStarsRepository, StarsRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

// Controllers
builder.Services.AddControllers();

// JwtBearer
builder.Services.AddAuthentication().AddJwtBearer();

// Caching
builder.Services.AddResponseCaching(options =>
{
    options.MaximumBodySize = 1024;
    options.UseCaseSensitivePaths = true;
});

// OData
builder.Services.AddControllers().AddOData(options =>
{
    options.Select().Filter().OrderBy();
});


#endregion Add Services

var app = builder.Build();

#region HTTP Request Pipeline

app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<ExceptionMiddleware>(); // Custom Exceptopn Middleware
app.UseHttpsRedirection();
app.UseCors("myPolicy");
app.UseResponseCaching();
app.UseMiddleware<CachingMiddleware>(); // Custom Caching Middleware
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

#endregion HTTP Request Pipeline

app.Run();
