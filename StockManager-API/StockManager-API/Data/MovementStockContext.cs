using Microsoft.EntityFrameworkCore;
using StockManager_API.Domains;

namespace StockManager_API.Data
{
    public class MovementStockContext : DbContext
    {
        protected readonly IConfiguration _configuration;


        public MovementStockContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(_configuration.GetConnectionString("StockManagerDatabase"));
        }

        public DbSet<Product> Products { get; set; }
    }
}
