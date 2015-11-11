using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client.DAL;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private ConfsContext db = new ConfsContext();

        // GET: Home
        public ActionResult Index()
        {
            var users = db.Users.Select(x => x);
            return View();
        }
    }
}