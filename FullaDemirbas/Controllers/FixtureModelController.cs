using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class FixtureModelController : Controller
    {
        FixtureModelManager FMM = new FixtureModelManager(new EfFixtureModelDal());
        SubCategoryManager SM = new SubCategoryManager(new EfSubCategoryDal());
        CategoryManager CM = new CategoryManager(new EfCategoryDal());
        ModelManeger MM = new ModelManeger(new EfModelDal());
        // GET: FixtureModel
        public ActionResult Index()
        {
            var fixturemodels = FMM.GetList();

            return View(fixturemodels);
        }
        [HttpGet]
        public ActionResult AddFixtureModel()
        {
            List<SelectListItem> valueSubCategory = (from x in SM.GetList()/*.Where(x => x.CategoryStatus == true)*/
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Category.CategoryName,
                                                      Value = x.Category.CategoryID.ToString()
                                                  }
                                                ).ToList();
            ViewBag.VbSubCategory = valueSubCategory;


            //List<SelectListItem> valueModel = (from x in MM.GetList()/*.Where(x => x.CategoryStatus == true)*/
            //                                         select new SelectListItem
            //                                         {
            //                                             Text = x.ModelName,
            //                                             Value = x.ModelID.ToString()
            //                                         }
            //                                    ).ToList();
            //ViewBag.VbvalueModel = valueModel;
            return View();
        }
        [HttpPost]
        public ActionResult AddFixtureModel(FixtureModel F)
        {
            FMM.FixtureModelAdd(F);
            return RedirectToAction("Index");
        }
        
    }
}