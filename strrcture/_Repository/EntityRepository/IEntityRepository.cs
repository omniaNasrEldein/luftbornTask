using Product.Data.Infrastructure._Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._Repository.EntityRepository
{
    public interface IEntityRepository<T> : IBaseRepository<T> where T : class
    {
    }
}
