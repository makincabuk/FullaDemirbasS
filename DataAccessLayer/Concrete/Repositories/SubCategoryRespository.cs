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
    public class SubCategoryRespository : ISubCategoryDal
    {
        public void Delete(SubCategory p)
        {
            throw new NotImplementedException();
        }

        public SubCategory Get(Expression<Func<SubCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(SubCategory p)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> List()
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> List(Expression<Func<SubCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(SubCategory p)
        {
            throw new NotImplementedException();
        }
    }
}
