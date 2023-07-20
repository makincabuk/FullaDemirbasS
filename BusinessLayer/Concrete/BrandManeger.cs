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
    public class BrandManeger : IBrandService
    {
        IBrandDal _brandal;

        public BrandManeger(IBrandDal brandDal)
        {
            _brandal = brandDal;
        }
        public void BrandAdd(Brand brand)
        {
            _brandal.Insert(brand);
        }

        public void BrandDisable(Brand brand)
        {

            _brandal.Update(brand);
        }

        public void BrandEnable(Brand brand)
        {
            _brandal.Update(brand);
        }

        public void BrandUpdate(Brand brand)
        {
            _brandal.Update(brand);
        }

        public Brand GetByID(int id)
        {
            return _brandal.Get(x => x.BrandID == id);
        }

        public List<Brand> GetList()
        {
            return _brandal.List();
        }
    }
}

