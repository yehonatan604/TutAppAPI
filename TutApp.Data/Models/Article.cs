using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TutApp.Data.Models
{
    public class Article
    {
        [Key] 
        public int Id { get; set; }

        public string UserEmail { get; set; }


        [ForeignKey(nameof(ImageId))] 
        public int ImageId { get; set; }
        public Image Image { get; set; }

        public CategoryTypes category { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int Stars { get; set; }
        public int Views { get; set; }

        public virtual IList<Comment> Comments { get; set; }
    }
}
