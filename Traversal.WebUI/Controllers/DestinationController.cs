using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IActionResult> Index()
        {
            var datas = await _destinationService.GetList();
            return View(datas);
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DestinationDetails(Destination destination)
        {


            return View();
        }
    }
}
