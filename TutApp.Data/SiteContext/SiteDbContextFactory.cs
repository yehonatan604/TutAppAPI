using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tut.Data.SiteDbContext;

namespace TutApp.Data.SiteContext
{
    public class SiteDbContextFactory : IDesignTimeDbContextFactory<SiteDbContext>
    {
        public SiteDbContext CreateDbContext(string[] args)
        {
            string directory = Directory.GetParent(Environment.CurrentDirectory)!.ToString();
            
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(directory + @"/TutApp.Api/")
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            DbContextOptionsBuilder<SiteDbContext> optionsBuilder = new();
            var conn = config.GetConnectionString("ConnectionString");
            optionsBuilder.UseSqlServer(conn);

            return new SiteDbContext(optionsBuilder.Options);
        }
    }
}
