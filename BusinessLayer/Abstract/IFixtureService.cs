using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFixtureService
    {

        List<Fixture> GetList();
        List<Fixture> GetListByFixtureID(int id);
        void FixtureAdd(Fixture fixture);
        Fixture GetByID(int id);
        void FixtureDelete(Fixture fixture);

        void FixtureUpdate(Fixture fixture);
    }
}
