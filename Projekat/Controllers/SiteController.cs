using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Pocetna()
        {
            return View();
        }

        public ActionResult Onama()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }
    }
}