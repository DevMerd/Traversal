using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        //FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        private readonly IFeatureService _featrue;
        public _FeaturePartial(IFeatureService feature)
        {
            _featrue = feature;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Feature> features = new List<Feature>();

            //var values = await featureManager.GetList();
            var values = await _featrue.GetList();

            foreach (var value in values)
            {
                Feature feature = new Feature()
                {
                    FeatureId = value.FeatureId,
                    Title = value.Title,
                    Description = value.Description,
                    Image = value.Image,
                    Status = value.Status
                };
                features.Add(feature);
            }
            ViewBag.v1Title = features[0].Title;
            ViewBag.v1Description = features[0].Description;

            ViewBag.v2Title = features[1].Title;
            ViewBag.v2Description = features[1].Description;

            ViewBag.v3Title = features[2].Title;
            ViewBag.v3Description = features[2].Description; 

            ViewBag.v4Title = features[3].Title;
            ViewBag.v4Description = features[3].Description;

            ViewBag.v5Title = features[4].Title;
            ViewBag.v5Description = features[4].Description;
            return View(values);
        }
    }
}
