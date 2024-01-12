using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _SubAboutDal;

        public SubAboutManager(ISubAboutDal SubAboutDal)
        {
            _SubAboutDal = SubAboutDal;
        }
        public Task<SubAbout> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubAbout>> GetList()
        {
            var datas = await _SubAboutDal.GetList();
            return datas;
        }

        public async Task TAdd(SubAbout entity)
        {
            await _SubAboutDal.Insert(entity);
        }

        public async Task TDelete(SubAbout entity)
        {
            await _SubAboutDal.Delete(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            _SubAboutDal.Update(entity);
        }
    }
}
