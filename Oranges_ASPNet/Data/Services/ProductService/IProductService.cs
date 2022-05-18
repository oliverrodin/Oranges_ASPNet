using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductsByIdAsync(int id);
        Task AddAsync(ProductViewModel product);
        Task UpdateAsync(int id, ProductViewModel product);
        Task DeleteAsync(int id);
        Task<List<Brand>> GetBrandDropdownValueAsync();

        

    }
}
