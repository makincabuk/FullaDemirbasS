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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public SubCategory GetByID(int id)
        {
            return _subCategoryDal.Get(x => x.SubCategoryID == id);
        }

        public List<SubCategory> GetList()
        {
            return _subCategoryDal.List();
        }

        public List<SubCategory> GetListBySubCategoryID(int id)
        {

            return _subCategoryDal.List(x => x.CategoryId == id);
        }

        public void SubCategoryAdd(SubCategory subcategory)
        {
             _subCategoryDal.Insert(subcategory);
        }

        public void SubCategoryDisable(SubCategory subcategory)
        {
            subcategory.SubCategoryStatus = false;
            SubCategoryUpdate(subcategory);
        }

        public void SubCategoryEnable(SubCategory subCategory)
        {
            subCategory.SubCategoryStatus = true;
            SubCategoryUpdate(subCategory);
        }

        //public void SubCategoryDelete(SubCategory subcategory) 
        //{
        //    subcategory.SubCategoryStatus = false;
        //    SubCategoryUpdate(subcategory);
        //    // _subCategoryDal.Delete(subcategory);

        //}

        public void SubCategoryUpdate(SubCategory subcategory)
        {
            _subCategoryDal.Update(subcategory);
        }
    }
}
