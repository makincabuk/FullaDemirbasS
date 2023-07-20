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
    public class BrandRepository : IBrandDal
    {
        public void Delete(Brand p)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Brand p)
        {
            throw new NotImplementedException();
        }

        public List<Brand> List()
        {
            throw new NotImplementedException();
        }

        public List<Brand> List(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand p)
        {
            throw new NotImplementedException();
        }
    }
}
