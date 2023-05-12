using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Tut.Data.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly IMapper _mapper;
        public ArticleRepository(SiteDbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
            
        }

        public async Task<bool> UpdateAsync(ArticlePutDTO entity)
        {
            Article? article = await _db.Articles.SingleOrDefaultAsync(article => article.Id == entity.Id);
            
            if (article == null)
            {
                return false;
            }

            article.Content = entity.Content;
            article.category = entity.Category;
            article.ImageId = entity.ImageId;
            
            await base.UpdateAsync(article);
            return true;
        }

        public async Task<List<ArticleGetDTO>> GetArticles()
        {
            var originalArticles = await base.GetAllAsync();
            var returnArticles = _mapper.Map<List<ArticleGetDTO>>(await _db.Articles.ToListAsync());

            for (int i = 0; i < originalArticles.Count; i++)
            {
                returnArticles[i].UserEmail = originalArticles[i].UserEmail;
                returnArticles[i].UserName = _db.Users
                    .SingleOrDefault(u => u.Email == returnArticles[i].UserEmail)!.UserName;
            }

            return returnArticles;
        }

        public async Task<bool> AddViewToArticle(int id)
        {
            
            var article = await _db.Articles.SingleOrDefaultAsync(u => u.Id == id);
            if (article != null) 
            {
                article.Views = article.Views+1;
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<bool> AddStarsToArticle(int id, int stars)
        {
            var article = await _db.Articles.SingleOrDefaultAsync(u => u.Id == id);

            if (article != null)
            {
                article.Stars = stars >= 5 ? 5 : stars; 
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
