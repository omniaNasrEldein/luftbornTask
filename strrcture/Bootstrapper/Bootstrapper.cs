using Microsoft.Extensions.DependencyInjection;
using Product.Data.Infrastructure._UnitOfWork.Unitofwork;
using Product.Data.Infrastructure._Repository.EntityRepository;
using Product.Data.Infrastructure._UniteOfWork;

namespace Product.Data.Infrastructure.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));


        }
    }

   
}
