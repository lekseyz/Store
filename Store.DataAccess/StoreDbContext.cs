using Microsoft.EntityFrameworkCore;
using Store.DataAccess.Entites;

namespace Store.DataAccess
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) 
            : base(options) { }

        public DbSet<StoreItemEntity> Items { get; set; }
    }
}
