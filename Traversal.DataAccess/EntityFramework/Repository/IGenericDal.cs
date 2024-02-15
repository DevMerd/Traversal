using System.Linq.Expressions;

namespace Traversal.DataAccess.EntityFramework.Repository
{
    public interface IGenericDal<T> where T : class, new()
    {
        Task Insert(T entity);
        Task Delete(T entity);
        void Update(T entity);
        Task<List<T>> GetList();
        Task<T> GetById(int id);
        Task<List<T>> GetListByFilter(Expression<Func<T, bool>> filter);

    }
}
