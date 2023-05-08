using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TutApp.Data.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new IdentityRole
                {
                    Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                    Name = "Creator",
                    NormalizedName = "CREATOR",
                },
                new IdentityRole
                {
                    Id = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                    Name = "User",
                    NormalizedName = "USER",
                });
        }
    }
}
