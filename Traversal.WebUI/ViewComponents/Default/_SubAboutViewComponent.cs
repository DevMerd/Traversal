using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _SubAboutViewComponent : ViewComponent
    {
        //SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        private readonly ISubAboutService _subAboutService;

        public _SubAboutViewComponent(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _subAboutService.GetList();
            return View(values);
        }
    }
}
