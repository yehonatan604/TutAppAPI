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
    [EnableQuery]
    [ApiController]

    public class StarsController : ControllerBase
    {
        private readonly IStarsRepository _repo;
        private readonly IMapper _mapper;

        public StarsController(IStarsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: api/Stars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stars>>> GetStars()
        {
            return Ok(await _repo.GetAllAsync());
        }

        // GET: api/Stars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stars>> GetStars(int id)
        {
            var stars = await _repo.GetAsync(id);
            return stars == null ? NotFound(id) : Ok(stars);
        }

        // PUT: api/Stars/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStars(int id, Stars stars)
        {
            if (id != stars.Id)
            {
                return BadRequest();
            }

            await _repo.UpdateAsync(stars);

            return NoContent();
        }

        // POST: api/Stars
        [HttpPost]
        public async Task<ActionResult<Stars>> PostStars(StarsPostDTO starsDTO)
        {
            Stars stars = _mapper.Map<Stars>(starsDTO);
            await _repo.AddAsync(stars);
            return CreatedAtAction("GetStars", new { id = stars.Id }, stars);
        }

        // DELETE: api/Stars/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteStars(int id)
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
