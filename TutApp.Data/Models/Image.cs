using System.ComponentModel.DataAnnotations;

namespace TutApp.Data.Models
{
    public class Image
    {
        [Key] 
        public int Id { get; set; }

        public string Title { get; set; }
        public string Location { get; set; }

        public virtual IList<Article> Articles { get; set; }
    }
}
