using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackendTalleresHN.PersistenciaDatos.Repository
{
    public class Repository<TalleresHNDbContext> : IRepository where TalleresHNDbContext : DbContext
    {
        private readonly TalleresHNDbContext _context;

        public Repository(TalleresHNDbContext context)
        {
            _context = context;
        }
        public async Task CreatedAsync<T>(T entity) where T : class
        {
            this._context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<T>>> GetAll<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById<T>(Expression<Func<T, bool>> t) where T : class
        {
            return await _context.Set<T>().Where(t).FirstOrDefaultAsync();
        }
    }
}
