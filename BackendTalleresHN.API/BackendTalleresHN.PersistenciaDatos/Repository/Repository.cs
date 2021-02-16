using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public Task CreatedAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<T>>> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById<T>(Expression<Func<T, bool>> t) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
