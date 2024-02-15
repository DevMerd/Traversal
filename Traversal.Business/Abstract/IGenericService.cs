namespace Traversal.Business.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        Task TAdd(T entity);
        Task TDelete(T entity);
        void TUpdate(T entity);
        Task<List<T>> GetList();
        Task<T> GetById(int id);
    }
}
