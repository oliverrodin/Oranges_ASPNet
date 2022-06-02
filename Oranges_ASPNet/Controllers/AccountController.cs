using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Data.Static;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.Include(u => u.Address).ToListAsync();
            return View(users);
        }

        



        public IActionResult Login() => View(new LoginViewModel());

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.FindByEmailAsync(model.EmailAddress);

            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, model.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Home", "Product");
                    }
                }
            }

            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(model);

        }



        public IActionResult Register() => View(new RegisterViewModel());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.FindByEmailAsync(model.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(model);
            }

            var newUser = new ApplicationUser()
            {
                FullName = $"{model.FirstName} {model.LastName}",
                Email = model.EmailAddress,
                UserName = model.EmailAddress,
                PhoneNumber = model.PhoneNumber,
                Address = new Address()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Street = model.Street,
                    Zip = model.Zip,
                    City = model.City,
                    State = model.State,
                    Country = model.Country
                }
            };

            var newUserResponse = await _userManager.CreateAsync(newUser, model.Password);
            await _context.SaveChangesAsync();

            if (newUserResponse.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            }

            return View("RegisterCompleted");
        }



        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Home", "Product");
        }



        public IActionResult AccessDenied(string returnUrl)
        {
            return View();
        }
    }
}
