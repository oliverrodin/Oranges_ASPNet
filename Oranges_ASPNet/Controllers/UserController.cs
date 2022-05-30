using Microsoft.AspNetCore.Mvc;
using Oranges_ASPNet.Data.Services.UserService;

namespace Oranges_ASPNet.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IActionResult> Index(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            
            return View(user);
        }
    }
}
