using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColegioColombia.Mvc.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor
        public ActionResult Index()
        {
            ViewBag.Bienvenida = "Hola Profesor";
            return View();
        }
    }
}