using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description siva page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact siva page.";

            return View();
        }
    }
}