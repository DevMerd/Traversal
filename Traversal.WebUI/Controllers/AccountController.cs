using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Entity.Concrete;
using Traversal.WebUI.Models;

namespace Traversal.WebUI.Controllers
{
    [AllowAnonymous]
    [Route("[Controller]/[Action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = viewModel.Name,
                    Surname = viewModel.Surname,
                    Email = viewModel.Mail,
                    UserName = viewModel.Username
                };
                if (viewModel.Password == viewModel.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(user, viewModel.Password);
                    if (result.Succeeded)
                        return RedirectToAction("Login");
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Username, viewModel.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { Area = "Member" });
                }
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
    }
}
