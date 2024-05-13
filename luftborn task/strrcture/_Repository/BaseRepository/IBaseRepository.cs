using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._Repository.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {

        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
        Task<bool> Insert(T entity);
        Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> filter = null, string includeProperties = "");
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null, string includeProperties = "");
        bool SaveChanges();

    }
}

