using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public async Task<Destination> GetById(int id)
        {
            return await _destinationDal.GetById(id);
        }

        public async Task<List<Destination>> GetList()
        {
            var datas = await _destinationDal.GetList();
            return datas;
        }

        public Task TAdd(Destination entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
