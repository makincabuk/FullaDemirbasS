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
    public class StoreManeger : IStoreService
    {
        IStoreDal _storeDal;

        public StoreManeger(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public Store GetByID(int id)
        {
            return _storeDal.Get(x => x.StoreID == id);
        }

        public List<Store> GetList()
        {
            return _storeDal.List();
        }

        public void StoreAdd(Store store)
        {
            _storeDal.Insert(store);
        }

        public void StoreDelete(Store store)
        {
            throw new NotImplementedException();
        }

        public void StoreUpdate(Store store)
        {
            _storeDal.Update(store);
        }
    }
}
