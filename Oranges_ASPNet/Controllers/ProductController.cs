﻿using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services.ProductService;

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
    }
}
