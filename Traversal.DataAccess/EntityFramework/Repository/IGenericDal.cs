using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.EntityFramework.Repository
{
    public interface IGenericDal<T> where T : class, new()
    {
        Task Insert(T entity);
        Task Delete(T entity);
        void Update(T entity);
        Task<List<T>> GetList();
    }
}
