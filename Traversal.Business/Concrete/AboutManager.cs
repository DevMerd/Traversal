using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public async Task<About> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<About>> GetList()
        {
            return await _aboutDal.GetList();
        }

        public async Task TAdd(About entity)
        {
           await _aboutDal.Insert(entity);
        }

        public async Task TDelete(About entity)
        {
           await _aboutDal.Delete(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
