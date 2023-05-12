using TutApp.Data.Models;

namespace TutApp.Core.DTOs
{
        public class ArticleGetDTO : ArticleDTO
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public int Views { get; set; }

        //public List<Comment> Comments { get; set; }
    }
}
