using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(IDbContextFactory<SiteDbContext> dbFactory) : base(dbFactory)
        {
        }
    }
}
