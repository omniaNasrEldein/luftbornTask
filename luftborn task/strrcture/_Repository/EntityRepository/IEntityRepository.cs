using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._Repository.EntityRepository
{
    public interface IEntityRepository<T> : Base.IBaseRepository<T> where T : class
    {
    }
}
