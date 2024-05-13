using Product.Data.Infrastructure._Repository.IRepository;
using Product.Data.Infrastructure._Repository.Repository;


namespace Product.Data.Infrastructure._UniteOfWork
{
    internal partial class UnitOfWork
    {
        public IProductRepositorycs EventRepository => new ProductRepository(AppDbContext, Mapper);
    }
