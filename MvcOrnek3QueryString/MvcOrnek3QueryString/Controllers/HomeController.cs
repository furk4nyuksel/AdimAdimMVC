using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek3QueryString.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string q)
        {
            return View();
        }

        public ActionResult Arama(string ara)
        {
            if (ara == "tht")
            {
                ViewBag.result = "Parametre Bulundu";
            }
            else
            {
                ViewBag.result = "Hatalı Parametre";
            }
            return View();
        }
        public ActionResult CokluArama(string nick,int yas=0)
        {
            if (nick!=null&&yas!=0)
            {
                ViewBag.nick = nick;
                ViewBag.yas = yas;
            }
            else
            {
                ViewBag.result = "Parametre Bulunamadı";
            }
            return View();
        }
    }
}