using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Client.Models;
using Client.DAL;
using AutoMapper;
using Client.Entities;

namespace Client.Controllers
{
    public class AccountController : Controller
    {
        private ConfsContext db = ConfsContext.Create();

        public ActionResult Registration()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid().ToString();
                db.Users.Add(Mapper.Map<RegistrationModel, User>(model));
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (db.Users.Any(o => o.Login == model.Login && o.Password == model.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(model.Login, true);
                var user = User.Identity.Name;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult _AccountPanel()
        {
            if (User.Identity.IsAuthenticated)
            {
                return PartialView(model: User.Identity.Name);
            }
            return PartialView(null);
        }
    }
}