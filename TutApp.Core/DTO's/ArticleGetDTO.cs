using TutApp.Data.Models;

namespace TutApp.Core.DTO_s
{
    public class ArticleGetDTO
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public int ImageId { get; set; }

        public CategoryTypes Category { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int Stars { get; set; }
        public int Views { get; set; }

        //public List<Comment> Comments { get; set; }
    }
}
