using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobsService
    {
        List<Jobs> GetList();
        void JobsAdd(Jobs jobs);
        Jobs GetByID(int id);
        void JobsDisable(Jobs jobs);

        void JobsEnable(Jobs jobs);
        void JobsUpdate(Jobs jobs);
    }
}
