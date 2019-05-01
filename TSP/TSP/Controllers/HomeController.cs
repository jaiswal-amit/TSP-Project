using DAL;
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
        TSPEntities _entities;
        DAL.RegistrationDetail objRegistration = new DAL.RegistrationDetail();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(LogInModel logInModel)
        {
            //if (logInModel.Mobile != null)
            //{
               
            //}
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
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(LogInModel objReg)
        {
            if (ModelState.IsValid)
            {
                if (!String.IsNullOrEmpty(objReg.UserID))
                {
                    _entities = new TSPEntities();
                    objRegistration.LoginType = objReg.LoginType;
                    objRegistration.UserID = objReg.UserID;
                    objRegistration.Password = objReg.Password;
                    objRegistration.ReEnteredPassword = objReg.ReEnteredPassword;
                    objRegistration.Email = objReg.Email;
                    objRegistration.DateOfBirth = objReg.DateOfBirth;
                    objRegistration.PhoneNumber = objReg.PhoneNumber;
                    _entities.RegistrationDetails.Add(objRegistration);
                    _entities.SaveChanges();
                }
            }
            return View();
        }
    }
}