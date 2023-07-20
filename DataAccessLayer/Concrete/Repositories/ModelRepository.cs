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
    public class ModelRepository : IModelDal
    {
        public void Delete(Model p)
        {
            throw new NotImplementedException();
        }

        public Model Get(Expression<Func<Model, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Model p)
        {
            throw new NotImplementedException();
        }

        public List<Model> List()
        {
            throw new NotImplementedException();
        }

        public List<Model> List(Expression<Func<Model, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Model p)
        {
            throw new NotImplementedException();
        }
    }
}
