using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutApp.Data.Models;

namespace TutApp.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    UserName = "Admin",
                    Email = "admin@email.com",
                    Password= "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Admin,
                    UserStatus = UserStatusTypes.LoggedOff,
                },
                new User
                {
                    UserName = "Rickey Melon",
                    Email = "melon@email.com",
                    Password= "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Reader,
                    UserStatus = UserStatusTypes.LoggedOff,
                },
                new User
                {
                    UserName = "Abed Zuhil",
                    Email = "abed@email.com",
                    Password = "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Creator,
                    UserStatus = UserStatusTypes.LoggedOff,
                },
                new User
                {
                    UserName = "Erik Lemon",
                    Email = "erik@email.com",
                    Password = "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Creator,
                    UserStatus = UserStatusTypes.LoggedOff,
                },
                new User
                {
                    UserName = "Chan Don Ma",
                    Email = "chan@email.com",
                    Password = "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Reader,
                    UserStatus = UserStatusTypes.LoggedOff,
                },
                new User
                {
                    UserName = "Al Viss",
                    Email = "al@email.com",
                    Password = "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Creator,
                    UserStatus = UserStatusTypes.LoggedOff,
                },
                new User
                {
                    UserName = "Donna Eyzer",
                    Email = "donna@email.com",
                    Password = "123#Abc123",
                    DOB = DateTime.Now,
                    UserType = UserTypes.Reader,
                    UserStatus = UserStatusTypes.LoggedOff,
                });
        }
    }
}
