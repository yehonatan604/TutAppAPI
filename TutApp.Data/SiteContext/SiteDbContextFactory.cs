using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tut.Model.SiteDbContext;

namespace TutApp.Data.SiteContext
{
    public class SiteDbContextFactory : IDesignTimeDbContextFactory<SiteDbContext>
    {
        public SiteDbContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().Build();

            DbContextOptionsBuilder<SiteDbContext> optionsBuilder = new();
            var conn = "Server=DESKTOP-T74S10A;Database=TutAppDb;Trusted_Connection = True;TrustServerCertificate= True;";
            optionsBuilder.UseSqlServer(conn);

            return new SiteDbContext(optionsBuilder.Options);
        }
    }
}
