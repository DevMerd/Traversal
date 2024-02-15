using Traversal.Entity.Concrete;

namespace Traversal.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> TGetDestinationById(int id);
    }
}
