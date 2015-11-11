using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Client.Models;
using Client.DAL;

namespace Client.Controllers
{
    public class AccountController : Controller
    {
        private ConfsContext db = new ConfsContext();

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
                db.Users.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}