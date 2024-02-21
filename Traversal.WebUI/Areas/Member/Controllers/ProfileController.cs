using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Traversal.Entity.Concrete;
using Traversal.WebUI.Areas.Member.Models;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var datas = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                Name = datas.Name,
                Surname = datas.Surname,
                Mail = datas.Email,
                PhoneNumber = datas.PhoneNumber
            };

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel editViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (editViewModel.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(editViewModel.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);

                await editViewModel.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.Name = editViewModel.Name;
            user.Surname = editViewModel.Surname;
            user.Email = editViewModel.Mail;
            user.PhoneNumber = editViewModel.PhoneNumber;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, editViewModel.Password);

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile", new { Area = "Member" });
            }
            return View();
        }

    }
}
