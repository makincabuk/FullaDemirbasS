using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class FixtureModelRepository : IFixtureModelDal
    {
        public void Delete(FixtureModel p)
        {
            throw new NotImplementedException();
        }

        public FixtureModel Get(Expression<Func<FixtureModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(FixtureModel p)
        {
            throw new NotImplementedException();
        }

        public List<FixtureModel> List()
        {
            throw new NotImplementedException();
        }

        public List<FixtureModel> List(Expression<Func<FixtureModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(FixtureModel p)
        {
            throw new NotImplementedException();
        }
    }
}
