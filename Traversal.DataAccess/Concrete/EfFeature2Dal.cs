﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Context;
using Traversal.DataAccess.EntityFramework.Repository;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.Concrete
{
    public class EfFeature2Dal : GenericRepository<Feature2, AppDbContext>, IFeature2Dal
    {
    }
}
