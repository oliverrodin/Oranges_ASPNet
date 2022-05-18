using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProductsAsync() => 
            await _context.Products.Include(b => b.Brand).ToListAsync();
        

        public Task<Product> GetAllProductsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
