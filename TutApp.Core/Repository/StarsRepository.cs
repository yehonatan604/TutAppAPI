using Microsoft.EntityFrameworkCore;
using Tut.Data.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class StarsRepository : GenericRepository<Stars>, IStarsRepository
    {
        public StarsRepository(SiteDbContext db) : base(db) 
        { 
        }

        public override async Task<Stars> AddAsync(Stars entity)
        {
            await base.AddAsync(entity);

            double totalStars = 0;
            var stars = await _db.Stars.ToListAsync();
            var relevanStars = stars.FindAll(e => e.ArticleId == entity.ArticleId);
            relevanStars.ForEach(star => totalStars += star.StarsGiven);
            
            var article = await _db.Articles.SingleOrDefaultAsync(item => item.Id == entity.ArticleId);
            
            if (article != null)
            {
                article.Stars = (int)Math.Round(totalStars / relevanStars.Count);
                _db.SaveChanges();
            }

            return entity;
        }
    }
}
