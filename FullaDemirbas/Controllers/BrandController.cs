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
    public class BrandController : Controller
    {
        // GET: Brand
        BrandManeger bm = new BrandManeger(new EfBrandDal());
        public ActionResult Index()
        {
            var brandvalues = bm.GetList();
            return View(brandvalues);
        }
        [HttpGet]
        public ActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBrand(Brand b)
        {
            bm.BrandAdd(b);
            return RedirectToAction("Index");
        }
        public ActionResult DisableBrand(int id)
        {
            var brandvalue = bm.GetByID(id);
            brandvalue.BrandStatus = false;
            bm.BrandDisable(brandvalue);
            return RedirectToAction("Index");
        }
        public ActionResult EnableBrand(int id)
        {
            var brandvalue = bm.GetByID(id);
            brandvalue.BrandStatus = true;
            bm.BrandEnable(brandvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditBrand(int id)
        {
            var brandvalue = bm.GetByID(id);
            return View(brandvalue);
        }
        [HttpPost]
        public ActionResult EditBrand(Brand b)
        {
            bm.BrandUpdate(b);
            return RedirectToAction("Index");
        }
    }
}