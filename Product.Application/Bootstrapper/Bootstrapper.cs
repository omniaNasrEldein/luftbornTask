using Microsoft.Extensions.DependencyInjection;
using Product.Application.AppService;
using Product.Application.IAppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void AddAppService(this IServiceCollection services)
        {
            Type[] appServices = Assembly.Load(typeof(ProductService).Assembly.GetName()).GetTypes().Where(a => a.IsClass).ToArray();
            Type[] iAppServices = Assembly.Load(typeof(IProductService).Assembly.GetName()).GetTypes().Where(a => a.IsInterface).ToArray();

            foreach (Type iAppService in iAppServices)
            {
                Type classType = appServices.FirstOrDefault(x => iAppService.IsAssignableFrom(x));
                if (classType != null)
                {
                    services.AddScoped(iAppService, classType);
                }
            }

        }
    }
}
