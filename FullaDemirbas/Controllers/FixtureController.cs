using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class FixtureController : Controller
    {
        // GET: Fixture
        FixtureManager fm = new FixtureManager(new EfFixtureDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FixtureBySubCategory(int id)
        {
            var fixturevalues = fm.GetListByFixtureID(id);
            return View(fixturevalues);
        }
    }
}