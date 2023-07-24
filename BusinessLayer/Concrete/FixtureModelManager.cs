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
    public class FixtureModelManager : IFixtureModelService
    {
        IFixtureModelDal _fixturemodeldal;
        
        public FixtureModelManager(IFixtureModelDal fixturemodelDal)
        {
            _fixturemodeldal = fixturemodelDal;
        }

        public void FixtureModelAdd(FixtureModel fixturemodel)
        {
            _fixturemodeldal.Insert(fixturemodel);
        }

        public void FixtureModelDelete(FixtureModel fixturemodel)
        {
            throw new NotImplementedException();
        }

        public void FixtureModelDisable(FixtureModel fixturemodel)
        {
            _fixturemodeldal.Update(fixturemodel);
        }

        public void FixtureModelEnable(FixtureModel fixturemodel)
        {
            _fixturemodeldal.Update(fixturemodel);
        }

        public void FixtureModelUpdate(FixtureModel fixturemodel)
        {
            _fixturemodeldal.Update(fixturemodel);
        }

        public FixtureModel GetByID(int id)
        {
            return _fixturemodeldal.Get(x => x.FixtureModelId == id);
        }

        public List<FixtureModel> GetList()
        {
            return _fixturemodeldal.List();
        }
    }
}
