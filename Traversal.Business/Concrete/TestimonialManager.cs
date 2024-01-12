using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Task<Testimonial> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Testimonial>> GetList()
        {
            var datas = await _testimonialDal.GetList();
            return datas;
        }

        public Task TAdd(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
