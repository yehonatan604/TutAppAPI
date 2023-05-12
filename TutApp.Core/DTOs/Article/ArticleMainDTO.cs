using TutApp.Data.Models;

namespace TutApp.Core.DTOs
{
    public class ArticleMainDTO
    {
        public int ImageId { get; set; }
        public string Content { get; set; }
        public CategoryTypes Category { get; set; }
    }
}
