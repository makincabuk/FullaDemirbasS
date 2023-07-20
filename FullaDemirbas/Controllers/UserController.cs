using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        UserValidator uservalidator = new UserValidator();
        public ActionResult Index()
        {
            var UserValues = um.GetList();
            return View(UserValues);
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User U)
        {
            ValidationResult result = uservalidator.Validate(U);
            if (result.IsValid)
            {
                um.UserAdd(U);
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
        public ActionResult EditUser(int id)
        {
            var uservalue = um.GetByID(id);
            return View(uservalue);
        }
        [HttpPost]
        public ActionResult EditUser(User U)
        {

            ValidationResult result = uservalidator.Validate(U);
            if (result.IsValid)
            {
                um.UserUpdate(U);
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

        public ActionResult DisableUser(int id)
        {
            var userevalue = um.GetByID(id);
            userevalue.UserStatus = false;
            um.UserUpdate(userevalue);
            return RedirectToAction("Index");
        }
        public ActionResult EnableUser(int id)
        {
            var userevalue = um.GetByID(id);
            userevalue.UserStatus = true;
            um.UserUpdate(userevalue);
            return RedirectToAction("Index");
        }
    }
}