using TutApp.Data.Models;

namespace TutApp.Core.DTOs
{
    public class ArticleMainDTO
    {
        public int ImageId { get; set; }
        public string Content { get; set; }
        public CategoryTypes Category { get; set; }
    }
    public class ArticlePutDTO : ArticleMainDTO
    {
        public int Id { get; set; }
    }

    public class ArticleDTO : ArticleMainDTO
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
    }

    public class ArticleGetDTO : ArticleDTO
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public int Views { get; set; }

        //public List<Comment> Comments { get; set; }
    }
}
