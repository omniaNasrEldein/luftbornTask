using Product.Data.Infrastructure._Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._UniteOfWork
{
    public partial interface IUnitOfWork
    {
        IProductRepositorycs ProductRepository { get; }
    }
