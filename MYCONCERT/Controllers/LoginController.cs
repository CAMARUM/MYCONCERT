using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using MYCONCERT.Models;
using NEGOCIOS;
using Newtonsoft.Json;

namespace MYCONCERT.Controllers
{
    public class LoginController : Controller
    {
        private N_Pais  _paisNegocio = new N_Pais();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult RegistrarUsuario(LoginViewModel pModel) {
            System.Diagnostics.Debug.WriteLine("Surprise Madafucker");
            if (!ModelState.IsValid)
            {
                return View(pModel);
            }
            string json = JsonConvert.SerializeObject(pModel);

            var result = _paisNegocio.registrar(json);
            System.Diagnostics.Debug.WriteLine(json);
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