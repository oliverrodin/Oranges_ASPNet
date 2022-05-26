using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Oranges_ASPNet.Data.Services.ProductService;
using Oranges_ASPNet.Data.Static;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var products = await _productService.GetAllProductsAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = products.Where(p => p.Model.ToLower().Contains(searchString.ToLower()) || p.Brand.Name.ToLower().Contains(searchString.ToLower())).ToList();
                return View("Index", filteredResult);
            }

            return View(products);
        }

        public async Task<IActionResult> List()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }

        [AllowAnonymous]
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

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productService.GetProductsByIdAsync(id);
            if (product == null)
            {
                return View("NotFound");
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productToDelete = await _productService.GetProductsByIdAsync(id);
            if (productToDelete != null)
            {
                await _productService.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            return View("NotFound");
        }

        public async Task<IActionResult> Create()
        {
            var brand = await _productService.GetBrandDropdownValueAsync();
            ViewBag.Brand = new SelectList(brand, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel product)
        {
            if (!ModelState.IsValid)
            {
                var brand = await _productService.GetBrandDropdownValueAsync();
                ViewBag.Brand = new SelectList(brand, "Id", "Name");
                return View(product);
            }
            await _productService.AddAsync(product);
            return View("Index");

        }
    }
}
