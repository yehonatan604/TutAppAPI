using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TutApp.Data.Models;

namespace TutApp.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            User admin;
            builder.HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = "Admin",
                    NormalizedUserName = "Admin".ToUpper(),
                    Email = "admin@email.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "admin@email.com".ToUpper(),
                    Password = "123#Abc123",
                    PasswordHash = hasher.HashPassword(null, "123#Abc123"),
                    DOB = DateTime.Now,
                    UserType = UserTypes.Admin,
                    UserStatus = UserStatusTypes.LoggedOff,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new User
                {
                    Id = "afa4728b-351f-4e2c-a903-3c80e77848e7",
                    UserName = "Abed Zuhil",
                    NormalizedUserName = "Abed Zuhil".ToUpper(),
                    Email = "abed@email.com",
                    NormalizedEmail = "abed@email.com".ToUpper(),
                    Password = "123#Abc123",
                    PasswordHash = hasher.HashPassword(null, "123#Abc123"),
                    DOB = DateTime.Now,
                    UserType = UserTypes.Creator,
                    UserStatus = UserStatusTypes.LoggedOff,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new User
                {
                    Id = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                    UserName = "Erik Lemon",
                    NormalizedUserName = "Erik Lemon".ToUpper(),
                    Email = "erik@email.com",
                    NormalizedEmail = "erik@email.com".ToUpper(),
                    Password = "123#Abc123",
                    PasswordHash = hasher.HashPassword(null, "123#Abc123"),
                    DOB = DateTime.Now,
                    UserType = UserTypes.Creator,
                    UserStatus = UserStatusTypes.LoggedOff,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new User
                {
                    Id = "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                    UserName = "Al Viss",
                    NormalizedUserName = "Al Viss".ToUpper(),
                    Email = "al@email.com",
                    NormalizedEmail = "al@email.com".ToUpper(),
                    Password = "123#Abc123",
                    PasswordHash = hasher.HashPassword(null, "123#Abc123"),
                    DOB = DateTime.Now,
                    UserType = UserTypes.Creator,
                    UserStatus = UserStatusTypes.LoggedOff,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                });
        }
    }
}
