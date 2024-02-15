using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Comments
{
    public class _AddComment : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
