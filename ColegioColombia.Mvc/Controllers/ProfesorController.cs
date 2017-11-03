using ColegioColombia.Mvc.Models;
using ColegioColombia.Mvc.ServicioColombia;
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

        public ActionResult IndexAlterno()
        {
            var modelo = new Profesor();
            modelo.Nombre = "Miguel";
            modelo.Apellido = "Peláez";
            modelo.Cedula = 4587854;

            ServicioColombiaSoapClient servicio = new ServicioColombiaSoapClient();

            ViewBag.SaludoPersonalizado = servicio.SaludoPersonalizado($"{modelo.Nombre} {modelo.Apellido}");

            return View(modelo);
        }
    }
}