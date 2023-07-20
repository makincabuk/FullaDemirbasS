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
    public class AdminManeger : IAdminService
    {
        IAdminDal _admindal;

        public AdminManeger(IAdminDal adminDal)
        {
            _admindal = adminDal;
        }
        public void AdminAdd(Admin admin)
        {
            _admindal.Insert(admin);
        }

        public void AdminDisable(Admin admin)
        {
            _admindal.Update(admin);
        }

        public void AdminEnable(Admin admin)
        {
            _admindal.Update(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _admindal.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _admindal.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _admindal.List();
        }
    }
}
