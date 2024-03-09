using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userValues = await _reservationService.GetListApprovedReservation(user.Id);
            return View(userValues);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userValues = await _reservationService.GetListPreviousReservation(user.Id);
            return View(userValues);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userValues = await _reservationService.GetListPendingApprovalReservation(user.Id);
            return View(userValues);
        }

        [HttpGet]
        public async Task<IActionResult> NewReservation()
        {
            List<SelectListItem> values = (from x in await _destinationService.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.Values = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            reservation.AppUser = user;
            reservation.Status = "Onay Bekliyor";
            await _reservationService.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}