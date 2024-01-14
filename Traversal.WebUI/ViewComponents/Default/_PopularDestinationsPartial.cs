using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        //private readonly DestinationManager _destinationManager;

        //public _PopularDestinationsPartial(DestinationManager destinationManager)
        //{
        //    _destinationManager = destinationManager;
        //}

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = await destinationManager.GetList();
            return View(datas);
        }
    }
}
