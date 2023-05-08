using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Contracts
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
        Task<List<ArticleGetDTO>> GetArticles();
        Task<bool> UpdateAsync(ArticlePutDTO entity);
        Task<bool> AddViewToArticle(int id);
        Task<bool> AddStarsToArticle(int id, int stars);
    }
}
