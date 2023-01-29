using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Data.Models;

namespace TutApp.Core.Repository
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(IDbContextFactory<SiteDbContext> dbFactory) : base(dbFactory)
        {
        }
    }
}
