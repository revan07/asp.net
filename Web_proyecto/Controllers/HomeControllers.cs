using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_proyecto.Controllers
{
    public class HomeControllers : Controller
    {
        // GET: Model
        public ActionResult FormularioVisita()
        {
            return View();
        }
    }
}