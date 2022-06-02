using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

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

        public async Task UpdateAsync(int id, BrandViewModel brand)
        {
            var item = await _context.Brands.FirstOrDefaultAsync(n => n.Id == brand.Id);

            if (item != null)
            {
                item.Id = brand.Id;
                item.Name = brand.Name;
                item.Country = brand.Country;
                item.LogoUrl = brand.LogoUrl;
                item.Address = brand.Address;

                await _context.SaveChangesAsync();
            }

        }
    

        public async Task DeleteAsync(int id)
        {
            var brand = await _context.Brands.FirstOrDefaultAsync(brand => brand.Id == id);
            if (brand != null)
            {
                _context.Brands.Remove(brand);
                await _context.SaveChangesAsync();
            }
        }
    }
}
