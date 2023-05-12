using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutApp.Data.Models
{
    public class Stars
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }

        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int StarsGiven { get; set; }
    }
}
