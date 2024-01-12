using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccess.Context;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            using (var context = new AppDbContext())
            {
                ViewBag.destination = context.Destinations.Count();
                ViewBag.guide = context.Guides.Count();
                ViewBag.customer = "471";
            }
            return View();
        }
    }
}
