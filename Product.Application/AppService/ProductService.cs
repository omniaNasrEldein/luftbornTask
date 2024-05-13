using AutoMapper;
using Date.Entity.BaseEntity;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Product.Application.Base.AppService;
using Product.Application.IAppService;
using Product.Data.Infrastructure._UniteOfWork;
using Product.Data.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.AppService
{
    public class ProductService : BaseAppService, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task<bool> Add(ProductDto productDto)
        {
            await UnitOfWork.ProductRepository.Create(productDto);
            if (await UnitOfWork.Commit() > default(int))
            {
                return true;
            }
            else { return false; }
        }

        public async Task<bool> Delete(int id)
        {
            return await this.UnitOfWork.ProductRepository.Delete(id);
        }

        public async Task<ProductDto> GetById(int id)
        {
            return await this.UnitOfWork.ProductRepository.GetById(id);
        }

        public async Task<List<ProductDto>> GetList()
        {
            return await this.UnitOfWork.ProductRepository.GetAll();
        }
        public async Task<bool> Update(ProductDto dto)
        {
            Date.Entity.Entity.Product entity = await this.UnitOfWork.ProductRepository.GetEntityById(dto.Id);
            if (entity != null)
            {
                entity.UpdateProduct(dto.Name, dto.Description, dto.Price);
                await UnitOfWork.ProductRepository.UpdateEvent(entity);
                if (await UnitOfWork.Commit() > default(int))
                {
                    return true;
                }
                else 
                { return false; }
            }
            else
            {
                return false;
            }
        }
    }
}
