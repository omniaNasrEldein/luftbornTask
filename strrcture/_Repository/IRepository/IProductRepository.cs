using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using Product.Data.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._Repository.IRepository
{
    public interface IProductRepository
    {
        Task<bool> Create(ProductDto entity);
        Task<ProductDto> GetById(int id);
        Task<bool> Delete(int id);
        Task<Date.Entity.Entity.Product> GetEntityById(int id);
        Task<bool> UpdateEvent(Date.Entity.Entity.Product obj);
        Task<List<ProductDto>> GetAll();
    }
}
