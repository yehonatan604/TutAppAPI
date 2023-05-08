using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Api.Controllers
{
    [Route("v{version:apiVersion}/api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    [EnableQuery]
    [Authorize]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMessageRepository _repo;

        public MessagesController(IMapper mapper, IMessageRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        // GET: api/Messages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageGetDTO>>> GetMessages()
        {
            List<MessageGetDTO> messages = _mapper.Map<List<MessageGetDTO>>(await _repo.GetAllAsync());
            messages.ForEach(msg => _repo.GetDetails(msg));
            return Ok(messages);
        }

        // GET: api/Messages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MessageGetDTO>> GetMessage(int id)
        {
            var message = await _repo.GetAsync(id);
            return message == null ? BadRequest(id) : Ok(_mapper.Map<MessageGetDTO>(message));
        }

        // POST: api/Messages
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            await _repo.AddAsync(message);
            return CreatedAtAction("GetMessage", new { id = message.Id }, message);
        }

        // DELETE: api/Messages/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            if (await _repo.GetAsync(id) == null)
            {
                return BadRequest(id);
            }

            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}
