using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(IDbContextFactory<SiteDbContext> dbFactory) : base(dbFactory)
        {
        }
    }
}
