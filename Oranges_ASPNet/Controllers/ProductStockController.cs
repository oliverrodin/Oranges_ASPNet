using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services.ProductStockService;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    public class ProductStockController : Controller
    {
        private readonly IProductStockService _productStockService;

        public ProductStockController(IProductStockService productStockService)
        {
            _productStockService = productStockService;
        }
        public async Task<IActionResult> Index()
        {
            var stock = await _productStockService.GetAllProductStocksAsync();
            return View(stock);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productStockService.GetProductStockByIdAsync(id);
            if (product == null)
            {
                return View("NotFound");
            }

            var response = new ProductStockViewModel()
            {
                Id = product.Id,
                Quantity = product.Quantity,
                ProductId = product.ProductId,
                Product = product.Product.Model,
                Brand = product.Product.Brand.Name,
                ImgUrl = product.Product.ImgUrl

            };

            return View(response);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductStockViewModel productStock)
        {
            if (id != productStock.Id)
            {
                return View("NotFound");
            }
            if (!ModelState.IsValid)
            {
                return View(productStock);
            }

            await _productStockService.UpdateAsync(id, productStock);
            return RedirectToAction("Index");
        }
    }
}
