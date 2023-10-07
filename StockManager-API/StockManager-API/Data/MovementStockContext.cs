using Microsoft.EntityFrameworkCore;
using StockManager_API.Domains;

namespace StockManager_API.Data
{
    public class MovementStockContext : DbContext
    {

        public MovementStockContext(DbContextOptions<MovementStockContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
