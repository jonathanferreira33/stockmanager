using StockManager_API.Domains;

namespace StockManager_API.Services.Interfaces
{
    public interface IMovementStockService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        Product PostProduct(Product product);
        Product UpdateProduc(Product product);
    }
}
