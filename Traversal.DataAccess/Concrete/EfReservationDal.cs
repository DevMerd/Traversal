using Microsoft.EntityFrameworkCore;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Context;
using Traversal.DataAccess.EntityFramework.Repository;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.Concrete
{
    public class EfReservationDal : GenericRepository<Reservation, AppDbContext>, IReservationDal
    {
        public async Task<List<Reservation>> GetListApprovedReservation(string id)
        {
            using (var context = new AppDbContext())
            {
                return await context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToListAsync();
            }
        }

        public async Task<List<Reservation>> GetListPendingApprovalReservation(string id)
        {
            using (var context = new AppDbContext())
            {
                return await context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToListAsync();
            }
        }

        public async Task<List<Reservation>> GetListPreviousReservation(string id)
        {
            using (var context = new AppDbContext())
            {
                return await context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToListAsync();
            }
        }
    }
}
