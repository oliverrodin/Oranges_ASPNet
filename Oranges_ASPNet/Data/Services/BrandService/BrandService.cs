using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;

        public BrandService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Brand>> GetAllBrandsAsync() => await _context.Brands.Include(b => b.Products).ToListAsync();

        public async Task<Brand> GetBrandByIdAsync(int id) =>
            await _context.Brands.Include(b => b.Products).FirstOrDefaultAsync(b => b.Id == id);

        public Task AddAsync(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
