using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _TestimonialViewComponent : ViewComponent
    {
        //TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        private readonly ITestimonialService _testimonialService;

        public _TestimonialViewComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetList();
            return View(values);
        }
    }
}
