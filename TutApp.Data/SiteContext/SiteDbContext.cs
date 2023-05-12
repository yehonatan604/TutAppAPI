using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TutApp.Data.Configurations;
using TutApp.Data.Models;

namespace Tut.Data.SiteDbContext
{
    public class SiteDbContext : IdentityDbContext<User>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Image> Images { get; set; }
        public new DbSet<User> Users { get; set; }
        public DbSet<Stars> Stars { get; set; }

        // Ctor
        public SiteDbContext(DbContextOptions options) : base(options) { }

        // overrides
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfig());
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new ImageConfig());
            builder.ApplyConfiguration(new ArticleConfig());
            builder.ApplyConfiguration(new UserRoleConfig());
        }
    }
}
