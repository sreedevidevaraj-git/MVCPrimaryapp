using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPrimaryapp.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.dis = "This is About Us Page info getting from controller as sample";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}