using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        IMapper _mapper;
        public ArticleRepository(IDbContextFactory<SiteDbContext> dbFactory, IMapper mapper) : base(dbFactory)
        {
            _mapper = mapper;
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
    }
}
