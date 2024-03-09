using Traversal.Entity.Concrete;

namespace Traversal.Business.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        Task<List<Reservation>> GetListApprovedReservation(string id);
        Task<List<Reservation>> GetListPendingApprovalReservation(string id);
        Task<List<Reservation>> GetListPreviousReservation(string id);
    }
}
