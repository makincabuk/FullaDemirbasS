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
    public class JobsManager : IJobsService
    {
        IJobsDal _jobsdal;
        public JobsManager(IJobsDal jobsvalue)
        {
            _jobsdal = jobsvalue;
        }
        public Jobs GetByID(int id)
        {
            return _jobsdal.Get(x => x.JobsID == id);
        }

        public List<Jobs> GetList()
        {
            return _jobsdal.List();
        }

        public void JobsAdd(Jobs jobs)
        {
            _jobsdal.Insert(jobs);
        }

        public void JobsDisable(Jobs jobs)
        {
            _jobsdal.Update(jobs);
        }

        public void JobsEnable(Jobs jobs)
        {
            _jobsdal.Update(jobs);
        }

        public void JobsUpdate(Jobs jobs)
        {
            _jobsdal.Update(jobs);
        }
    }
}
