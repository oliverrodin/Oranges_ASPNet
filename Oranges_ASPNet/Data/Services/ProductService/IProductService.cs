using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetAllProductsAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(int id, Product product);
        Task DeleteAsync(int id);

    }
}
