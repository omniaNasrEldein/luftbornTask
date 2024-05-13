using Microsoft.EntityFrameworkCore;
using Product.Data.Entity;

namespace Product.Data.Infrastructure.Context
{
    public partial class AppDbContext
    {
        #region DBSet
        public DbSet<Product.Data.Entity.Product> Product { get; set; }

    }
}
