using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaRecados.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Esse sistema foi copiado com sucesso pelo Paulo Soares";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "página pra contado";

            return View();
        }
    }
}