using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanfordMIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Background Info";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The Contact Page.";

            return View();
        }
    }
}