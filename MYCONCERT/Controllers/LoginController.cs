﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYCONCERT.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarUsuario() {
            System.Diagnostics.Debug.WriteLine("Surprise Madafucker2");
            return View();
        }
    }
}