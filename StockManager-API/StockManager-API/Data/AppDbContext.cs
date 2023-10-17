using Microsoft.EntityFrameworkCore;
using StockManager_API.Domains;

namespace StockManager_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Log> Logs { get; set; } = default!;
    }
}
