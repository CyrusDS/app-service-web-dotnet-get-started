using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult JobSummary()
        {
            ViewBag.Message = "Your Job Summary page.";

            return View();
        }
        public ActionResult Responsibilities()
        {
            ViewBag.Message = "Your Responsibilities page.";

            return View();
        }
        public ActionResult MyQuestions()
        {
            ViewBag.Message = "My Responsibilities page.";

            return View();
        }
    }
}