﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class AdminRepository : IAdminDal
    {
        public void Delete(Admin p)
        {
            throw new NotImplementedException();
        }

        public Admin Get(Expression<Func<Admin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Admin p)
        {
            throw new NotImplementedException();
        }

        public List<Admin> List()
        {
            throw new NotImplementedException();
        }

        public List<Admin> List(Expression<Func<Admin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin p)
        {
            throw new NotImplementedException();
        }
    }
}
