using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.ProductStockService
{
    public class ProductStockService : IProductStockService
    {
        private readonly AppDbContext _context;

        public ProductStockService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductStock>> GetAllProductStocksAsync()
        {
            return await _context.ProductStocks.Include(p => p.Product)
                .ThenInclude(p => p.Brand).ToListAsync();
        }

        public async Task<ProductStock> GetProductStockByIdAsync(int id)
        {
            return await _context.ProductStocks.Include(p => p.Product)
                .ThenInclude(p => p.Brand)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(int id, ProductStockViewModel productStock)
        {
            var stock = await _context.ProductStocks.FindAsync(id);

            if (stock != null)
            {
                stock.Quantity = productStock.Quantity;
                await _context.SaveChangesAsync();
            }
        }
    }
}
