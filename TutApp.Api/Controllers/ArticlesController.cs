using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableQuery]

    public class ArticlesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IArticleRepository _repo;

        public ArticlesController(IMapper mapper, IArticleRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleGetDTO>>> GetArticles()
        {
            return await _repo.GetArticles();
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            var article = await _repo.GetAsync(id);
            await _repo.AddViewToArticle(id);
            return article == null ? NotFound(id) : Ok(article);
        }

        // GET: api/Articles/AddStarsToArticle/5
        [Route("addStarsToArticle/{id}/{stars}")]
        public async Task<ActionResult<bool>> AddStarsToArticle(int id, int stars)
        {
            return await _repo.AddStarsToArticle(id, stars);
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Creator, Admin")]
        public async Task<IActionResult> PutArticle(int id, Article article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }

            await _repo.UpdateAsync(article);

            return NoContent();
        }

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("addNewArticle")]
        [Authorize(Roles = "Creator, Admin")]
        public async Task<ActionResult<ArticleGetDTO>> AddNewArticle(ArticleDTO articleDto)
        {
            var article = _mapper.Map<Article>(articleDto);
            await _repo.AddAsync(article);
            return CreatedAtAction("GetArticle", new { id = article.Id }, article);
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Creator, Admin")]
        public async Task<bool> DeleteArticle(int id)
        {
            if (await _repo.GetAsync(id) == null)
            {
                return false;
            }

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
