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
    public class SubCategoryController : Controller
    {
        // GET: SubCategory
        SubCategoryManager sm = new SubCategoryManager(new EfSubCategoryDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var subcategoryvalues = sm.GetList();
            return View(subcategoryvalues);
        }
        public ActionResult DSubCategory()
        {

            var subcategoryvalues = sm.GetList();
            return View(subcategoryvalues);
        }

        [HttpGet]
        public ActionResult AddSubCategory()
        {

            List<SelectListItem> valuecategory = (from x in cm.GetList()/*.Where(x => x.CategoryStatus == true)*/
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }
                                                ).ToList();
            ViewBag.vlsc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory Sb)
        {
            SubCategoryValidator subcategoryvalidator = new SubCategoryValidator();
            ValidationResult result = subcategoryvalidator.Validate(Sb);
            if (result.IsValid)
            {
                sm.SubCategoryAdd(Sb);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditSubCategory(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()/*.Where(x => x.CategoryStatus == true)*/
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }
                                                  ).ToList();
            ViewBag.vlsc = valuecategory;
            var SubCategoryValue = sm.GetByID(id);
            return View(SubCategoryValue);


        }
        [HttpPost]
        public ActionResult EditSubCategory(SubCategory s)
        {
            sm.SubCategoryUpdate(s);
            return RedirectToAction("Index");
        }
        public ActionResult EnableSubCategory(int id)
        {

            try
            {
                var SubCategoryValue = sm.GetByID(id);
                sm.SubCategoryEnable(SubCategoryValue);
                if (Request.UrlReferrer.Segments[2].ToString() == "SubCategoryByCategory/")
                {
                    return RedirectToAction(Request.UrlReferrer.Segments[2] + "/" + Request.UrlReferrer.Segments[3]);
                }
                else
                {

                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }

        }
        public ActionResult DisableSubCategory(int id)
        {
            try
            {
                var SubCategoryValue = sm.GetByID(id);
                sm.SubCategoryDisable(SubCategoryValue);
                if (Request.UrlReferrer.Segments[2].ToString() == "SubCategoryByCategory/")
                {
                    return RedirectToAction(Request.UrlReferrer.Segments[2] + "/" + Request.UrlReferrer.Segments[3]);
                }
                else
                {
                    return RedirectToAction("Index");

                }
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }

        }

        public ActionResult SubCategoryByCategory(int id)
        {//Category sayfasındaki detay butonun işlevleri
            var subcategoryvalues = sm.GetListBySubCategoryID(id);
            return View(subcategoryvalues);
        }
    }

}