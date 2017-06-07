using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using MYCONCERT.Models;
using MYCONCERT.Negocio;
namespace MYCONCERT.Controllers
{
    public class LoginController : Controller
    {
        private N_Pais  paisNegocio = new N_Pais();
        // GET: Login
        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult RegistrarUsuario(LoginViewModel model) {
            System.Diagnostics.Debug.WriteLine("Surprise Madafucker");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            System.Diagnostics.Debug.WriteLine("Entro Entro");

            var result = paisNegocio.getPaisAll(model);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}