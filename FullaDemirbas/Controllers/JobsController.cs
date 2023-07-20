using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class JobsController : Controller
    {
        JobsManager jm = new JobsManager(new EfJobsDal());

        // GET: Jobs
        public ActionResult Index()
        {
            var jobsvalues = jm.GetList();
            return View(jobsvalues);
        }
        [HttpGet]
        public ActionResult AddJobs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJobs(Jobs j)
        {
            jm.JobsAdd(j);
            return RedirectToAction("Index");
        }
        public ActionResult DisableJobs(int id)
        {
            var jobsvalue = jm.GetByID(id);
            jobsvalue.JobsStatus= false;
            jm.JobsUpdate(jobsvalue);
            return RedirectToAction("Index");
        }
        public ActionResult EnableJobs(int id)
        {
            var jobsvalue = jm.GetByID(id);
            jobsvalue.JobsStatus = true;
            jm.JobsUpdate(jobsvalue);
            return RedirectToAction("Index");
        }
    }
}