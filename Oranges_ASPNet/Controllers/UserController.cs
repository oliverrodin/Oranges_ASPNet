using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services;
using Oranges_ASPNet.Data.Services.ProductService;
using Oranges_ASPNet.Data.Services.ProductStockService;
using Oranges_ASPNet.Data.Services.UserService;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrdersService _ordersService;
        private readonly IProductService _productService;
        private readonly IProductStockService _stockService;

        public UserController(IUserService userService, IOrdersService ordersService, IProductService productService, IProductStockService stockService)
        {
            _userService = userService;
            _ordersService = ordersService;
            _productService = productService;
            _stockService = stockService;
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
            data.Stocks = await _stockService.GetAllProductStocksAsync();

            return View(data);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var user = await _userService.GetAddressByIdAsync(id);
            if (user == null)
            {
                return View("NotFound");
            }

            var response = new UserViewModel()
            {
                Street = user.Street,
                State = user.State,
                City = user.City,
                Country = user.Country,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Zip = user.Zip,
                Id = user.AddressId,
            };
            return View(response);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, UserViewModel user)
        {
            if (id != user.Id)
            {
                return View("NotFound");
            }
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            await _userService.UpdateAsync(id, user);
            return RedirectToAction("Index");
        }

    }
}
