using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services.ProductService;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProductService _productService;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IProductService productService, ShoppingCart shoppingCart)
        {
            _productService = productService;
            _shoppingCart = shoppingCart;
        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }
    }
}
