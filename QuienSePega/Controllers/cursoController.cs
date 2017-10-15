using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuienSePega.Controllers
{
    public class cursoController : Controller
    {
        // GET: curso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult cursoHtml()
        {
            return View();
        }

    }
}