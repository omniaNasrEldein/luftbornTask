using System.Linq.Expressions;
using AutoMapper;

namespace Product.Data.Infrastructure._Repository.BaseRepository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Properties
        public IMapper Mapper { get; }
        public Context.AppDbContext AppDbContext { get; }
        #endregion
        #region Constructor

        internal BaseRepository(Context.AppDbContext appDbContext, IMapper mapper)
        {
            AppDbContext = appDbContext;
            Mapper = mapper;
        }
        #endregion
        #region Methods

        public Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
  
        #endregion

    }

    }
