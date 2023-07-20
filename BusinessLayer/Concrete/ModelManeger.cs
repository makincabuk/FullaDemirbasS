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
    public class ModelManeger : IModelService
    {
        IModelDal _modeldal;
        public ModelManeger(IModelDal modelDal)
        {
            _modeldal = modelDal;
        }
        public Model GetByID(int id)
        {
            return _modeldal.Get(x => x.ModelID == id);
        }

        public List<Model> GetList()
        {
            return _modeldal.List();
        }

        public void ModelAdd(Model model)
        {
            _modeldal.Insert(model);
        }

        public void ModelDisable(Model model)
        {
            _modeldal.Update(model);
        }

        public void ModelEnable(Model model)
        {
            _modeldal.Update(model);
        }

        public void ModelUpdate(Model model)
        {
            _modeldal.Update(model);
        }
    }
}
