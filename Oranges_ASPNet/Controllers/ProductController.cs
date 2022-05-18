using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Oranges_ASPNet.Data.Services.ProductService;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetProductsByIdAsync(id);
            if (product == null)
            {
                return View("NotFound");
            }

            return View(product);

        }
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetProductsByIdAsync(id);
            if (product == null)
            {
                return View("NotFound");
            }

            var response = new ProductViewModel()
            {
                Id = product.Id,
                Model = product.Model,
                Description = product.Description,
                BrandId = product.BrandId,
                Price = product.Price,
                Category = product.Category,
                ImgUrl = product.ImgUrl,
            };

            var brand = await _productService.GetBrandDropdownValueAsync();
            ViewBag.Brand = new SelectList(brand, "Id", "Name");
            return View(response);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductViewModel product)
        {
            if (id != product.Id)
            {
                return View("NotFound");
            }
            if (!ModelState.IsValid)
            {
                var brand = await _productService.GetBrandDropdownValueAsync();
                ViewBag.Brand = new SelectList(brand, "Id", "Name");
                return View(product);
            }
            await _productService.UpdateAsync(id, product);
            return RedirectToAction("Index");
        }
    }
}
