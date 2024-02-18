﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Traversal.Entity.Concrete;
using Traversal.WebUI.Models;

namespace Traversal.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
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
                        return RedirectToAction("SignIn");
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
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
