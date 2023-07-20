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
    class FixtureRepository : IFixtureDal
    {
        public void Delete(Fixture p)
        {
            throw new NotImplementedException();
        }

        public Fixture Get(Expression<Func<Fixture, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Fixture p)
        {
            throw new NotImplementedException();
        }

        public List<Fixture> List()
        {
            throw new NotImplementedException();
        }

        public List<Fixture> List(Expression<Func<Fixture, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Fixture p)
        {
            throw new NotImplementedException();
        }
    }
}
