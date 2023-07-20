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
    public class JobsRepository : IJobsDal
    {
        public void Delete(Jobs p)
        {
            throw new NotImplementedException();
        }

        public Jobs Get(Expression<Func<Jobs, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Jobs p)
        {
            throw new NotImplementedException();
        }

        public List<Jobs> List()
        {
            throw new NotImplementedException();
        }

        public List<Jobs> List(Expression<Func<Jobs, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Jobs p)
        {
            throw new NotImplementedException();
        }
    }
}
