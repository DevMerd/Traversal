using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traversal.Business.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
        }

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
            List<SelectListItem> values = (from x in await _destinationService.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.Values = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            reservation.AppUserId = "bd192bb1-bbc6-45f0-b88d-041a14ca0de8";
            reservation.Status = true;
            await _reservationService.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
