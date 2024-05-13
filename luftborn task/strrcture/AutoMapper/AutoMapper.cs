using AutoMapper;

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
            //CreateMap<Entity.Product, ProductDto>();
            //CreateMap<Entity.ContactUs, ContactUsDto>()
            //    .AfterMap((src, dest) => dest.StatusName = Enum.GetName(typeof(ContactUsStatusEnum), dest.StatusId));
        }

    }
}
