using Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvaluacionTecnicaApi.Controllers
{
    public class HomeController : Controller
    {
        private EvaluacionTecnicaDbContext db = new EvaluacionTecnicaDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}