using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FixtureManager : IFixtureService
    {
        IFixtureDal _fixtureDal;

        public FixtureManager(IFixtureDal fixtureDal)
        {
            _fixtureDal = fixtureDal;
        }

        public void FixtureAdd(Fixture fixture)
        {
            throw new NotImplementedException();
        }

        public void FixtureDelete(Fixture fixture)
        {
            throw new NotImplementedException();
        }

        public void FixtureUpdate(Fixture fixture)
        {
            throw new NotImplementedException();
        }

        public Fixture GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fixture> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Fixture> GetListByFixtureID(int id)
        {
            return _fixtureDal.List(x => x.SubCategoryId==id);
        }
    }
}
