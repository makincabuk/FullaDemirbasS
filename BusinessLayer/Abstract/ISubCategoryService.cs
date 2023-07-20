using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubCategoryService
    {

        List<SubCategory> GetList();
        void SubCategoryAdd(SubCategory subcategory);
        SubCategory GetByID(int id);
        void SubCategoryDisable(SubCategory subcategory);

        void SubCategoryEnable(SubCategory subCategory);
        void SubCategoryUpdate(SubCategory subcategory);


        List<SubCategory> GetListBySubCategoryID(int id);
        //List<SubCategory> GetList();
        //void SubCategoryAdd(SubCategory subcategory);
        //void SubCategoryDelete(SubCategory subcategory);
        //void SubCategoryUpdate(SubCategory subcategory);
        //SubCategory GetByID(int id);
    }
}
