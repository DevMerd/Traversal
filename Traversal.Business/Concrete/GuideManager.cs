using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public Task<Guide> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Guide>> GetList()
        {
            return await _guideDal.GetList();
        }

        public Task TAdd(Guide entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guide entity)
        {
            throw new NotImplementedException();
        }
    }
}
