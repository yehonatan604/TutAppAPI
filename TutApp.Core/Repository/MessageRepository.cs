using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(IDbContextFactory<SiteDbContext> dbFactory) : base(dbFactory)
        {
        }

        public MessageGetDTO GetDetails(MessageGetDTO messageDTO)
        {
            User sender = _db.Users.SingleOrDefault(
                user => user.Email == messageDTO.SenderEmail)!;

            User reciver = _db.Users.SingleOrDefault(
                user => user.Email == messageDTO.ReciverEmail)!;

            messageDTO.SenderName = sender.UserName;
            messageDTO.ReciverName = reciver.UserName;

            return messageDTO;
        }
    }
}
