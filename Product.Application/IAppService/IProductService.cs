using Product.Data.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.IAppService
{
   public interface IProductService
    {
        Task<bool> Add(ProductDto productDto);
        Task<bool> Update(ProductDto productDto);
        Task<ProductDto> GetById(int id);
        Task<bool> Delete(int Id);
        Task<List<ProductDto>> GetList();

    }
}
