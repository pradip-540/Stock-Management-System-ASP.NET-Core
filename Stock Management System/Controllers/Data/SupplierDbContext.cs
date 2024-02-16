using Microsoft.EntityFrameworkCore;
using Stock_Management_System.Models;

namespace Stock_Management_System.Controllers.Data
{
    public class SupplierDbContext : DbContext
    {
        public SupplierDbContext(DbContextOptions<SupplierDbContext> options)
          : base(options)
        {

        }

        // DbSet properties for your entities
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
