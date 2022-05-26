using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.ProductStockService
{
    public interface IProductStockService
    {
        Task<List<ProductStock>> GetAllProductStocksAsync();
        Task<ProductStock> GetProductStockByIdAsync(int id);
        Task UpdateAsync(int id, ProductStockViewModel productStock);
    }
}
