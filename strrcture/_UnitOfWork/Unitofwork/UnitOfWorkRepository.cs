
using AutoMapper;
using Product.Data.Infrastructure._Repository.IRepository;
using Product.Data.Infrastructure._Repository.Repository;
using Product.Data.Infrastructure.Context;

namespace Product.Data.Infrastructure._UnitOfWork.Unitofwork
{
       partial class UnitOfWork
    {
        public IProductRepository ProductRepository => new ProductRepository(AppDbContext, Mapper);

    }
}
