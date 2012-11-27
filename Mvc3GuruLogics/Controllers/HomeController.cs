using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc3GuruLogics.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            
            ViewBag.CurPage = "Home";
            return View();
        }

        public ActionResult AboutUs() 
        {
            ViewBag.CurPage = "AboutUs";
            
            return View();
        
        }


        public ActionResult ContactUs()
        {
            ViewBag.CurPage = "ContactUs";

            return View();

        }


        public ActionResult Services()
        {
            ViewBag.CurPage = "Services";

            return View();

        }

    }
}
