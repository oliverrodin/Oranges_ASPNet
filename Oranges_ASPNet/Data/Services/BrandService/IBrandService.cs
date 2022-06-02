using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.BrandService
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandsAsync();
        Task<Brand> GetBrandByIdAsync(int id);
        Task AddAsync(Brand brand);
        Task UpdateAsync(int id, BrandViewModel brand);
        Task DeleteAsync(int id);
    }
}
