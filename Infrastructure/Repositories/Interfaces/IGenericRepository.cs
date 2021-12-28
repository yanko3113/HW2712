using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HW27122021.Infrastructure.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T:class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(int id);
        Task<T> add(T entity);
        Task<bool> Upsert(T entity);//crea o actualiza
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

    }
}
