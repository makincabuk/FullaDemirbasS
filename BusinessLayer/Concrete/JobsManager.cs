using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobsManager : IJobsService
    {
        public Admin GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Jobs> GetList()
        {
            throw new NotImplementedException();
        }

        public void JobsAdd(Jobs jobs)
        {
            throw new NotImplementedException();
        }

        public void JobsDisable(Jobs jobs)
        {
            throw new NotImplementedException();
        }

        public void JobsEnable(Jobs jobs)
        {
            throw new NotImplementedException();
        }

        public void JobsUpdate(Jobs jobs)
        {
            throw new NotImplementedException();
        }
    }
}
