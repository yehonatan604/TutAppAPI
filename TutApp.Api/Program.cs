using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContextFactory<SiteDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-T74S10A;Database=TutAppDb;Trusted_Connection = True;TrustServerCertificate= True;");
});

builder.Services.AddIdentityCore<User>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<SiteDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
