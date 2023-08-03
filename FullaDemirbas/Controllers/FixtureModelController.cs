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
            FixtureModel a = new FixtureModel();
            viewbagCreate();
            return View(Tuple.Create(fixturemodels));
        }
        void viewbagCreate()
        {
            List<SelectListItem> valueSubCategory = (from x in SM.GetList().Where(x => x.SubCategoryStatus == true)
                                                     select new SelectListItem
                                                     {
                                                         Text = x.SubCategoryName,
                                                         Value = x.SubCategoryID.ToString()
                                                     }
                                                ).ToList();
            ViewBag.VbSubCategory = valueSubCategory;


            List<SelectListItem> valueModel = (from x in MM.GetList()/*.Where(x => x.CategoryStatus == true)*/
                                               select new SelectListItem
                                               {
                                                   Text = x.ModelName,
                                                   Value = x.ModelID.ToString()
                                               }
                                                ).ToList();
            ViewBag.VbvalueModel = valueModel;
        }
        [HttpGet]
        public ActionResult AddFixtureModel()
        {
             viewbagCreate();
            return View();
        }
        [HttpPost]
        public ActionResult AddFixtureModel(FixtureModel F)
        {
            FMM.FixtureModelAdd(F);
            return RedirectToAction("Index");
        }
        public ActionResult DisableFixtureModel(int id)
        {
            var fixturemodelvalue = FMM.GetByID(id);
            fixturemodelvalue.FixtureModelStatus = false;
            FMM.FixtureModelUpdate(fixturemodelvalue);
            return RedirectToAction("Index");
        }
        public ActionResult EnableFixtureModel(int id)
        {
            var fixturemodelvalue = FMM.GetByID(id);
            fixturemodelvalue.FixtureModelStatus = true;
            FMM.FixtureModelUpdate(fixturemodelvalue);
            return RedirectToAction("Index");
        }

    }
}