using Microsoft.EntityFrameworkCore;
using Tut.Data.SiteDbContext;
using TutApp.Core.Contracts;

namespace TutApp.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SiteDbContext _db;
        public GenericRepository(SiteDbContext db)
        {
            _db = db;
        }

        //GET
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetAsync(int? id)
        {
            return (id is not null ? await _db.Set<T>().FindAsync(id) : null)!;
        }

        // POST
        public virtual async Task<T> AddAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        // PUT
        public virtual async Task UpdateAsync(T entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }

        // DELETE {Id}
        public virtual async Task DeleteAsync(int? id)
        {
            var entity = await GetAsync(id);
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }

        // Assistant Methods
        public virtual async Task<bool> Exists(int? id)
        {
            return await GetAsync(id) != null;
        }

    }
}
