﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Client.Models;

namespace Client.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}