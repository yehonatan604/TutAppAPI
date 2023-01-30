using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Contracts
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        MessageGetDTO GetDetails(MessageGetDTO messageDTO);
    }
}
