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

        public ActionResult JobSummary()
        {
            // ViewBag.ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d3/Colorado_Buffaloes_logo.svg/1200px-Colorado_Buffaloes_logo.svg.png";
            ViewBag.Message = "Job Skills!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact page.";

            return View();
        }

        public ActionResult JobNeeds()
        {
            ViewBag.ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d3/Colorado_Buffaloes_logo.svg/1200px-Colorado_Buffaloes_logo.svg.png";
            ViewBag.Message = "IT Systems Engineer!";

            return View();
        }
        public ActionResult Responsibilities()
        {
            ViewBag.Message = "What my Responsibilities Would be:";

            return View();
        }
        public ActionResult MyQuestions()
        {
            // ViewBag.Message = "My Questions page.";

            return View();
        }
    }
}