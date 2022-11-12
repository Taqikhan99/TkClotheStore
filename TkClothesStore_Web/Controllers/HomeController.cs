using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TkClothesStore_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page is well.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your Contact Page is poor!.";

            return View();
        }
    }
}