using Product.Data.Infrastructure._Repository.IRepository;

namespace Product.Data.Infrastructure._UniteOfWork
{
    public partial interface IUnitOfWork
    {
      IProductRepository ProductRepository { get; }
    }
}
