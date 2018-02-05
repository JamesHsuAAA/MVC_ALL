using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ITest Test;
        private ITest Test2;
        public HomeController(ITest test,ITest test2)
        {
            this.Test = test;
            this.Test2 = test2;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var str1 = Test.test1();
            var str2 = Test.test2();
            var str3 = Test2.test1();
            var str4 = Test2.test2();

            return View();
        }
    }
}
