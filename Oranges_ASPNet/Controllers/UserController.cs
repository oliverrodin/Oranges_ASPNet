using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services;
using Oranges_ASPNet.Data.Services.UserService;

namespace Oranges_ASPNet.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrdersService _ordersService;

        public UserController(IUserService userService, IOrdersService ordersService)
        {
            _userService = userService;
            _ordersService = ordersService;
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
    }
}
