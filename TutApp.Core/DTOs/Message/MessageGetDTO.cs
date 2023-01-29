using TutApp.Data.Models;

namespace TutApp.Core.DTOs
{
    public class MessageGetDTO
    {
        public int Id { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string ReciverEmail { get; set; }
        public string ReciverName { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public MessageStatusTypes Status { get; set; }
    }
}
