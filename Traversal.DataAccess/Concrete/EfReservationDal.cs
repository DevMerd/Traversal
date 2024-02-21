using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Context;
using Traversal.DataAccess.EntityFramework.Repository;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.Concrete
{
    public class EfReservationDal : GenericRepository<Reservation, AppDbContext>, IReservationDal
    {
    }
}
