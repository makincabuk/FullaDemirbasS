using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IModelService
    {
        List<Model> GetList();
        void ModelAdd(Model admin);
        Model GetByID(int id);
        void ModelDisable(Model admin);

        void ModelEnable(Model admin);
        void ModelUpdate(Model admin);
    }
}
