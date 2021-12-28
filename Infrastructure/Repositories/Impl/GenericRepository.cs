using HW27122021.Infrastructure.DataContext;
using HW27122021.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HW27122021.Infrastructure.Repositories.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        protected DbContextHW _dbContext;
        protected DbSet<T> dbSet;
        public GenericRepository(DbContextHW _context)
        {
            this._dbContext = _context;
            this.dbSet = _context.Set<T>();
        }
        public async Task<T> add(T entity)
        {
            var res= (await dbSet.AddAsync(entity));
            await _dbContext.SaveChangesAsync();
            return res.Entity;
        }

        public async Task<IEnumerable<T>> All()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var enntity = await GetById(id);            
            dbSet.Remove(enntity);
            _dbContext.SaveChanges();
            return true;
        }

        public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
