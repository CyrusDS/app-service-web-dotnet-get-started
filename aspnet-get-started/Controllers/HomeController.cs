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
            ViewBag.ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d3/Colorado_Buffaloes_logo.svg/1200px-Colorado_Buffaloes_logo.svg.png";
            ViewBag.Message = "IT Systems Engineer";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JobNeeds()
        {
            ViewBag.Message = "Your Job Needs page.";

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