using StockManager_API.Data;
using StockManager_API.Domains;
using StockManager_API.Services.Interfaces;

namespace StockManager_API.Services
{
    
    public class MovementStockService : IMovementStockService
    {
        private readonly MovementStockContext _movementStockContext;

        public MovementStockService(MovementStockContext movementStockContext)
        {
            _movementStockContext = movementStockContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            var product = products.FirstOdDefault(produtc => produtc.Id == id);

            throw new NotImplementedException();
        }

        public Product PostProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduc(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
