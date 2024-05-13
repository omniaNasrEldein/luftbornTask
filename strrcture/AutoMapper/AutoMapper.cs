using AutoMapper;
using Product.Data.Infrastructure.Dto;

namespace Product.Data.Infrastructure.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            ProductMapping();
         
        }
        private void ProductMapping()
        {
            CreateMap<Date.Entity.Entity.Product, ProductDto>();
            CreateMap<ProductDto, Date.Entity.Entity.Product>();
        }

    }
}
