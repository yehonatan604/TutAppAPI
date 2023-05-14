using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using TutApp.Core.Contracts;
using TutApp.Data.Models;

namespace TutApp.Api.Controllers
{
    [Route("v{version:apiVersion}/api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    [EnableQuery]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository _repo;
        public ImagesController(IImageRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Images
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Image>>> GetImages()
        {
            return Ok(await _repo.GetAllAsync());
        }

        // GET: api/Images/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImage(int id)
        {
            var image = await _repo.GetAsync(id);
            return image == null ? NotFound(id) : Ok(image);
        }

        // PUT: api/Images/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImage(int id, Image image)
        {
            if (id != image.Id)
            {
                return BadRequest();
            }

            await _repo.UpdateAsync(image);

            return NoContent();
        }

        // POST: api/Images
        [HttpPost]
        public async Task<ActionResult<Image>> PostImage(Image image)
        {
            await _repo.AddAsync(image);
            return CreatedAtAction("GetImage", new { id = image.Id }, image);
        }

        // DELETE: api/Images/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteImage(int id)
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
