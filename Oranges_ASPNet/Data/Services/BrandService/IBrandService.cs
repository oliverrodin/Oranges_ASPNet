using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.BrandService
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandsAsync();
        Task<Brand> GetBrandByIdAsync(int id);
        Task AddAsync(Brand brand);
        Task UpdateAsync(int id, Brand brand);
        Task DeleteAsync(int id);
    }
}
