using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services.BrandService;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;
using System.Threading.Tasks;

namespace Oranges_ASPNet.Controllers
{
    
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var brands = await _brandService.GetAllBrandsAsync();
            return View(brands);

        }

        public async Task<IActionResult> Details(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            if (brand == null)
            {
                return View("NotFound");
            }

            return View(brand);

        }

        public async Task<IActionResult> Edit(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            if (brand == null)
            {
                return View("NotFound");
            }

            var response = new BrandViewModel()
            {
                Id = brand.Id,
                Address = brand.Address,
                LogoUrl = brand.LogoUrl,
                Country = brand.Country,
                Name = brand.Name,
            };
            return View(response);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, BrandViewModel brand)
        {
            if (id != brand.Id)
            {
                return View("NotFound");
            }
            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            await _brandService.UpdateAsync(id, brand);
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            if (brand == null)
            {
                return View("NotFound");
            }

            return View(brand);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brandToDelete = await _brandService.GetBrandByIdAsync(id);
            if (brandToDelete != null)
            {
                await _brandService.DeleteAsync(id);
                return RedirectToAction("List");
            }
            return View("NotFound");
        }
    }
}
