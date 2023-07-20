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
    public class ModelController : Controller
    {
        ModelManeger MM = new ModelManeger(new EfModelDal());
        // GET: Model
        public ActionResult Index()
        {
            var modelvalues = MM.GetList();
            return View(modelvalues);
        }
        [HttpGet]
        public ActionResult AddModel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddModel(Model M)
        {
            MM.ModelAdd(M);
            return RedirectToAction("Index");
        }
        public ActionResult DisableModel(int id)
        {
            var modelvalue = MM.GetByID(id);
            modelvalue.ModelStatus = false;
            MM.ModelUpdate(modelvalue);
            return RedirectToAction("Index");
        }
        public ActionResult EnableModel(int id)
        {
            var modelvalue = MM.GetByID(id);
            modelvalue.ModelStatus = true;
            MM.ModelUpdate(modelvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditModel(int id)
        {
            var modelvalue = MM.GetByID(id);
            return View(modelvalue);
        }
        [HttpPost]
        public ActionResult EditModel(Model m)
        {
            MM.ModelUpdate(m);
            return RedirectToAction("Index");
        }
    }
}