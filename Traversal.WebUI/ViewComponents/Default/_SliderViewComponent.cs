using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _SliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
