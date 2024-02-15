using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Task<Comment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task TAdd(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Comment>> TGetDestinationById(int id)
        {
            return await _commentDal.GetListByFilter(x => x.DestinationId == id);
        }
    }
}
