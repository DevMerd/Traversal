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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Task<Feature> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Feature>> GetList()
        {
            return await _featureDal.GetList();
        }

        public Task TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
