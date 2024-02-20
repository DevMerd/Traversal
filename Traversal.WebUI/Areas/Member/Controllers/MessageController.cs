using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
