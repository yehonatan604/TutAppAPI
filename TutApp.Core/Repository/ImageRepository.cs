using Microsoft.EntityFrameworkCore;
using Tut.Data.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(SiteDbContext db) : base(db)
        {
        }
    }
}
