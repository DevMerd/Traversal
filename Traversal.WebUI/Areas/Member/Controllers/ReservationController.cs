using Microsoft.AspNetCore.Mvc;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public async Task<IActionResult> MyCurrentReservation()
        {
            return View();
        }

        public async Task<IActionResult> MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> NewReservation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            return View();
        }
    }
}
