using System;
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
<<<<<<< HEAD
            System.Diagnostics.Debug.WriteLine("Surprise Madafucker");
=======
            System.Console.WriteLine("Hi!");

>>>>>>> b037b957d0d2c67b9ece1b71448a79a6acb2d771
            return View();
        }
    }
}