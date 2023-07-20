using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FullaDemirbas.Controllers
{
    public class LoginController : Controller
    {
        AdminManeger ADM = new AdminManeger(new EfAdminDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin A)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminUsername == A.AdminUsername && x.AdminUserPassword == A.AdminUserPassword);
            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUsername,false);
                Session["AdminUsername"] = adminuserinfo.AdminUsername;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin A)
        {
            ADM.AdminAdd(A);
            return RedirectToAction("Index");
        }
        public ActionResult DisableAdmin(int id)
        {
            var adminvalue = ADM.GetByID(id);
            adminvalue.AdminStatus = false;
            ADM.AdminDisable(adminvalue);
            return RedirectToAction("Index");
        }
        public ActionResult EnableAdmin(int id)
        {
            var adminvalue = ADM.GetByID(id);
            adminvalue.AdminStatus = true;
            ADM.AdminDisable(adminvalue);
            return RedirectToAction("Index");
        }
    }
}