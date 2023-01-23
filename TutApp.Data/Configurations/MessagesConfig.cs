using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutApp.Data.Models;

namespace TutApp.Data.Configurations
{
    public class MessagesConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            string content = "ברוכים הבאים לתות!\nשימוש מהנה באתר";
            string adminEmail = "admin@email.com";

            builder.HasData(
                new Message
                {
                    Id = 1,
                    SenderEmail = adminEmail,
                    ReciverEmail = "abed@email.com",
                    Title = "Welcome",
                    Content = content,
                    Created = DateTime.Now,
                    Status = MessageStatusTypes.Sent
                },
                new Message
                {
                    Id = 2,
                    SenderEmail = adminEmail,
                    ReciverEmail = "melon@email.com",
                    Title = "Welcome",
                    Content = content,
                    Created = DateTime.Now,
                    Status = MessageStatusTypes.Sent
                },
                new Message
                {
                    Id = 3,
                    SenderEmail = adminEmail,
                    ReciverEmail = "erik@email.com",
                    Title = "Welcome",
                    Content = content,
                    Created = DateTime.Now,
                    Status = MessageStatusTypes.Sent
                },
                new Message
                {
                    Id = 4,
                    SenderEmail = adminEmail,
                    ReciverEmail = "chan@email.com",
                    Title = "Welcome",
                    Content = content,
                    Created = DateTime.Now,
                    Status = MessageStatusTypes.Sent
                },
                new Message
                {
                    Id = 5,
                    SenderEmail = adminEmail,
                    ReciverEmail = "al@email.com",
                    Title = "Welcome",
                    Content = content,
                    Created = DateTime.Now,
                    Status = MessageStatusTypes.Sent
                },
                new Message
                {
                    Id = 6,
                    SenderEmail = adminEmail,
                    ReciverEmail = "donna@email.com",
                    Title = "Welcome",
                    Content = content,
                    Created = DateTime.Now,
                    Status = MessageStatusTypes.Sent
                }

            );
        }
    }
}
