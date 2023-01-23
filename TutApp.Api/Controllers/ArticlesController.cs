using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Diagnostics;
using Tut.Model.SiteDbContext;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableQuery]

    public class ArticlesController : ControllerBase
    {
        private readonly SiteDbContext _context;
        private readonly IMapper _mapper;

        public ArticlesController(IDbContextFactory<SiteDbContext> dbContextFactory, IMapper mapper)
        {
            _context = dbContextFactory.CreateDbContext();
            _mapper = mapper;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleGetDTO>>> GetArticles()
        {
            var originalArticles = await _context.Articles.ToListAsync();
            var returnArticles = _mapper.Map<List<ArticleGetDTO>>(await _context.Articles.ToListAsync());

            for (int i = 0; i < originalArticles.Count; i++)
            {
                returnArticles[i].UserEmail = originalArticles[i].UserEmail;
                returnArticles[i].UserName = _context.Users
                    .SingleOrDefault(u => u.Email == returnArticles[i].UserEmail)!.UserName;
            }

            return returnArticles;
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int id, Article article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }

            _context.Entry(article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
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

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("addNewArticle")]
        public async Task<ActionResult<ArticleGetDTO>> AddNewArticle(ArticleDTO articleDto)
        {
            var article = _mapper.Map<Article>(articleDto); 
            
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return Ok(article);
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
