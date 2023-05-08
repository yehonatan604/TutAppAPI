using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutApp.Data.Configurations
{
    public class UserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    // admin
                    RoleId = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },
                new IdentityUserRole<string>
                {
                    // creator
                    RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                    UserId = "afa4728b-351f-4e2c-a903-3c80e77848e7"
                },
                new IdentityUserRole<string>
                {
                    // creator
                    RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                    UserId = "59f65e3a-706c-4056-a0bc-c4597e08599e"
                },
                new IdentityUserRole<string>
                {
                    // creator
                    RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                    UserId = "41e09971-aa5d-44f2-8dd2-37ab94cb7708"
                }
                );
        }
    }
}
