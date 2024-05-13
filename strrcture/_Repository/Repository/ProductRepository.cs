using AutoMapper;
using Date.Entity.BaseEntity;
using Product.Data.Infrastructure._Repository.EntityRepository;
using Product.Data.Infrastructure._Repository.IRepository;
using Product.Data.Infrastructure.Context;
using Product.Data.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._Repository.Repository
{
    public class ProductRepository : EntityRepository<Date.Entity.Entity.Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {
        }


        public Task<bool> Create(ProductDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Date.Entity.Entity.Product> GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEvent(Date.Entity.Entity.Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
