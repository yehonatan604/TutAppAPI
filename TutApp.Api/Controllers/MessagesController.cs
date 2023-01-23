using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableQuery]
    public class MessagesController : ControllerBase
    {
        private readonly SiteDbContext _context;
        private readonly IMapper _mapper;

        public MessagesController(IDbContextFactory<SiteDbContext> dbContextFactory, IMapper mapper)
        {
            _context = dbContextFactory.CreateDbContext();
            _mapper = mapper;
        }

        // GET: api/Messages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageGetDTO>>> GetMessages()
        {
            List<MessageGetDTO> messages = _mapper.Map<List<MessageGetDTO>>(await _context.Messages.ToListAsync());
            messages.ForEach(msg => GetDetails(msg));
            return Ok(messages);
        }

        // GET: api/Messages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MessageGetDTO>> GetMessage(int id)
        {
            var message = await _context.Messages.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            return _mapper.Map<MessageGetDTO>(message);
        }

        // PUT: api/Messages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessage(int id, Message message)
        {
            if (id != message.Id)
            {
                return BadRequest();
            }

            _context.Entry(message).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Messages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.Id }, message);
        }

        // DELETE: api/Messages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessageExists(int id)
        {
            return _context.Messages.Any(e => e.Id == id);
        }

        private MessageGetDTO GetDetails(MessageGetDTO messageDTO)
        {
            User sender =  _context.Users.SingleOrDefault(
                user => user.Email == messageDTO.SenderEmail)!;

            User reciver =  _context.Users.SingleOrDefault(
                user => user.Email == messageDTO.ReciverEmail)!;

            messageDTO.SenderName = sender.UserName;
            messageDTO.ReciverName= reciver.UserName;

            return messageDTO;
        }
    }
}
