using Traversal.DataAccess.EntityFramework.Repository;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        Task<List<Reservation>> GetListPendingApprovalReservation(string id);

        Task<List<Reservation>> GetListApprovedReservation(string id);

        Task<List<Reservation>> GetListPreviousReservation(string id);
    }
}
