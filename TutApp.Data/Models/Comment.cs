using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TutApp.Data.Models
{
    public class Comment
    {
        [Key] public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public string Content { get; set; }
        public DateTime Created { get; set; }
        public CommentStatusTypes CommentStatus { get; set; }
    }
}
