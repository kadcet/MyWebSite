using Microsoft.EntityFrameworkCore;

namespace MyWebSite.Models
{
    public class ETradeDbContext:DbContext
    {
        public ETradeDbContext(DbContextOptions<ETradeDbContext> options)
            :base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
