using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

           ///localhost/Home/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saat()
        {
            return View();
        }
    }
}