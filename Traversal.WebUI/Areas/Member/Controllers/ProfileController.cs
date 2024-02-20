using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
