using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Index metodu //View tarafında karşılığı var
        {
            return View();
        }

        public ActionResult About() //Hakkında metodu //View tarafında karşılığı var
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() //İletişim metodu //View tarafında karşılığı var
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test ()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Homepage()
        {
            return View();
        }
    }
}