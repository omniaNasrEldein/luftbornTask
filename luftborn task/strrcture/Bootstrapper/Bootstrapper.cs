using Microsoft.Extensions.DependencyInjection;
using Product.Data.Infrastructure._UniteOfWork;
using Product.Data.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
            services.AddScoped(typeof(UnitOfWork.IUnitOfWork), typeof(UnitOfWork.UnitOfWork));

        }
    }

    internal interface IEntityRepository<T>
    {
    }
}
