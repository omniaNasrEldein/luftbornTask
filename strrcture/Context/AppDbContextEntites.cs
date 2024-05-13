using Microsoft.EntityFrameworkCore;

namespace Product.Data.Infrastructure.Context
{
    public partial class AppDbContext
    {
        #region DBSet
        public DbSet<Date.Entity.Entity.Product> Product { get; set; }
        #endregion
    }
}
