

using Microsoft.EntityFrameworkCore.Design;

namespace Product.Presentation.Api.Infrastructure.Context
{
    public class ContextDesignTimeFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(GetConnectionString(), options => options.MigrationsAssembly(GetType().Assembly.GetName().Name));

            return new AppDbContext(optionsBuilder.Options);
        }

        private static string GetConnectionString()
        {
            var configurationBuilder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile($"{Directory.GetCurrentDirectory()}/bin/Debug/net6.0/appsettings.json", optional: false, reloadOnChange: true)
              .Build();

            return configurationBuilder["ConnectionString"];
        }
    }
}
