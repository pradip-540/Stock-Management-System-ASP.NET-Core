using Microsoft.EntityFrameworkCore;
using Stock_Management_System.Models;

namespace Stock_Management_System.Controllers.Data
{
    public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<View> ViewAllItems { get; set; }
        // Add other DbSet properties for additional entities if needed
    }
}
