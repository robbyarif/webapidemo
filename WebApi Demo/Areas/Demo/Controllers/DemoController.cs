using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi_Demo.Areas.Demo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo/Demo
        public ActionResult Index()
        {
            return View();
        }
    }
}