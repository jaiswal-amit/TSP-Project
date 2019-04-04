using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSP.Models;

namespace TSP.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(LogInModel logInModel)
        {
            if (logInModel.Mobile != null)
            {
               
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CommonLogIn()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}