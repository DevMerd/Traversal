using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;

namespace Traversal.Business.Registrations
{
    public static class BusinessRegistrations
    {
        public static void AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDestinationService, DestinationManager>();
            services.AddSingleton<IDestinationDal, EfDestinationDal>();

            services.AddSingleton<IFeatureService, FeatureManager>();
            services.AddSingleton<IFeatureDal, EfFeatureDal>();

            services.AddSingleton<ISubAboutService, SubAboutManager>();
            services.AddSingleton<ISubAboutDal, EfSubAboutDal>();

            services.AddSingleton<ITestimonialService, TestimonialManager>();
            services.AddSingleton<ITestimonialDal, EfTestimonialDal>();

            services.AddSingleton<ICommentService, CommentManager>();
            services.AddSingleton<ICommentDal, EfCommentDal>();

            services.AddSingleton<IReservationService, ReservationManager>();
            services.AddSingleton<IReservationDal,EfReservationDal>();

        }
    }
}
