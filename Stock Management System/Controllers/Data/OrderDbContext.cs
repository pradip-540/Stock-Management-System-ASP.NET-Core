using Microsoft.EntityFrameworkCore;
using Stock_Management_System.Models;
namespace Stock_Management_System.Controllers.Data
{
    public class OrderDbContext: DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
           : base(options)
        {

        }

        // DbSet properties for your entities
        public DbSet<SellItems> SoldItems { get; set; }
    }
}
