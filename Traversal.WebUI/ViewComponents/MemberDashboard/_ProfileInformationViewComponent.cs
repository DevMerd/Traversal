using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.ViewComponents.MemberDashboard
{

    public class _ProfileInformationViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public _ProfileInformationViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet ]
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.MemberName = user.Name + " " + user.Surname;
            //ViewBag.MemberPhone = user.PhoneNumber;
            return View(user);
        }
    }
}
