using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Easyservice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      
     
        public ActionResult Signinpage()
        {
            return View();
        }

        public ActionResult Signuppage()
        {
            return View();
        }

        public ActionResult Complaints()
        {
            return View();
        }
        public ActionResult Support()
        {
            return View();
        }


    }
}