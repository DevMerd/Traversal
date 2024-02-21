using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public async Task<Reservation> GetById(int id)
        {
           return await _reservationDal.GetById(id);
        }

        public async Task<List<Reservation>> GetList()
        {
            var datas = await _reservationDal.GetList();
            return datas;
        }

        public async Task TAdd(Reservation entity)
        {
            await _reservationDal.Insert(entity);
        }

        public Task TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
