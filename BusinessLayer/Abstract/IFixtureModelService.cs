using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFixtureModelService
    {

        List<FixtureModel> GetList();
        void FixtureModelAdd(FixtureModel fixturemodel);
        FixtureModel GetByID(int id);
        void FixtureModelDelete(FixtureModel fixturemodel);
        void FixtureModelDisable(FixtureModel fixturemodel);

        void FixtureModelEnable(FixtureModel fixturemodel);
        void FixtureModelUpdate(FixtureModel fixturemodel);
    }
}
