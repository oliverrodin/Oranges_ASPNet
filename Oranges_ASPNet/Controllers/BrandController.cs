using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services.BrandService;
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
    }
}
