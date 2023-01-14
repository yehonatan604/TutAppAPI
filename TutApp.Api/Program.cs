using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Configurations;
using TutApp.Data.Models;

var builder = WebApplication.CreateBuilder(args);

#region Add Services

builder.Services.AddControllers();

// Add DbContextFactory
builder.Services.AddDbContextFactory<SiteDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-T74S10A;Database=TutAppDb;Trusted_Connection = True;TrustServerCertificate= True;");
});

//Add AutoMapper

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

// Add IdentityCore
builder.Services.AddIdentityCore<User>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<SiteDbContext>();

// Add Cors
builder.Services.AddCors(x => x.AddPolicy(
    "myPolicy", c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin())
);

#endregion Add Services


var app = builder.Build();

#region HTTP Request Pipeline

app.UseHttpsRedirection();

app.UseCors("myPolicy");

app.UseAuthorization();

app.MapControllers();

#endregion HTTP Request Pipeline

app.Run();
