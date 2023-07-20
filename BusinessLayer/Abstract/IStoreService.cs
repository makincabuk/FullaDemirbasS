using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IStoreService
    {
        List<Store> GetList();
        void StoreAdd(Store store);
        void StoreDelete(Store store);
        void StoreUpdate(Store store);
        Store GetByID(int id);
    }
}
