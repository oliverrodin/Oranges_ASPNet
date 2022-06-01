using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services;
using Oranges_ASPNet.Data.Services.ProductService;
using Oranges_ASPNet.Data.Services.UserService;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrdersService _ordersService;
        private readonly IProductService _productService;

        public UserController(IUserService userService, IOrdersService ordersService, IProductService productService)
        {
            _userService = userService;
            _ordersService = ordersService;
            _productService = productService;
        }
        public async Task<IActionResult> Index(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);

            var orders = await _ordersService.GetOrdersByUserIdAndRoleAsync(userId, userRole);

            ViewBag.Orders = orders;
            return View(user);
        }

        public async Task<IActionResult> AdminDashboard()
        {

            var data = new DashboardViewModel();
            data.Orders = await _ordersService.GetOrdersByUserIdAndRoleAsync(
                User.FindFirstValue(ClaimTypes.NameIdentifier), User.FindFirstValue(ClaimTypes.Role));
            data.Products = await _productService.GetAllProductsAsync();
            data.ApplicationUsers = await _userService.GetAllUsersAsync();
            return View(data);
        }
    }
}
