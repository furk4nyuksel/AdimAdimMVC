using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek2ViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.isim = "ibanez75612";
            ViewBag.yas = 19;
            ViewBag.Yil = 2019;
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}