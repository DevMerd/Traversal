using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;

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
    }
}
