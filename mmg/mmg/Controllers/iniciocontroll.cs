using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmg.Controllers
{
    public class iniciocontroll : Controller
    {
        // GET: iniciocontroll
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioVisita()
        {
            return View();
        }

    }
}