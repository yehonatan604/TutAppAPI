using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Contracts
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
        Task<List<ArticleGetDTO>> GetArticles();
    }
}
