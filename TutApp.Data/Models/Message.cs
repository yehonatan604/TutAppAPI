using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutApp.Data.Models
{
    public class Message
    {
        [Key] public int Id { get; set; }

        [ForeignKey("SenderId")] 
        public User? Sender { get; set; }

        [ForeignKey("ReciverId")] 
        public User? Reciver { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public MessageStatusTypes Status { get; set; }
    }
}
