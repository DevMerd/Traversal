using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _SubAboutPartial : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await subAboutManager.GetList();
            return View(values);
        }
    }
}
