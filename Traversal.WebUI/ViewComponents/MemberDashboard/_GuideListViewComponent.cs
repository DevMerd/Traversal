using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.ViewComponents.MemberDashboard
{
    public class _GuideListViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IGuideService _guideService;
        public _GuideListViewComponent(UserManager<AppUser> userManager, IGuideService guideService)
        {
            _userManager = userManager;
            _guideService = guideService;
        }

        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = await _guideService.GetList();
            return View(datas);
        }
    }
}
