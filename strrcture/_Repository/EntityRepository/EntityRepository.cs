using AutoMapper;
using Product.Data.Infrastructure._Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._Repository.EntityRepository
{
    public class EntityRepository<T> : BaseRepository<T>, IEntityRepository<T> where T : class
    {

        public EntityRepository(Context.AppDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {


        }
    }
}
