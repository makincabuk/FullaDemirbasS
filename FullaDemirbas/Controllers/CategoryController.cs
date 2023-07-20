using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
            //}
            //[HttpPost]
            //public ActionResult AddCategory(Category p)
            //{
            //    cm.CategoryAdd(j);
            //    return RedirectToAction("Index");
            //}
            //public ActionResult DisableStore(int id)
            //{
            //    var storevalue = SM.GetByID(id);
            //    storevalue.StoreStatus = false;
            //    SM.StoreUpdate(storevalue);
            //    return RedirectToAction("Index");
            //}
        }
    }
}