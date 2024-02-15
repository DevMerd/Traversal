using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _PopularDestinationsViewComponent : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _PopularDestinationsViewComponent(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = await _destinationService.GetList();
            return View(datas);
        }
    }
}
