using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await testimonialManager.GetList();
            return View(values);
        }
    }
}
