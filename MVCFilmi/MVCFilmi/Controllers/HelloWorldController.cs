using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilmi.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pozdravljen(string ime,int koliko=1)
        {
            ViewBag.Message = "Pozdravljen, " + ime;
            ViewBag.Num = koliko;
            return View();
        }
    }
}