using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek8CookieKonusu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.Cookies["cookies"] == null)
            {
                HttpCookie cookie = new HttpCookie("cookies");
                cookie["visitDate"] = DateTime.Now.ToString();
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);
            }
            else
            {
                HttpCookie cookie = Request.Cookies["cookies"];
                if (cookie != null)
                {
                    ViewBag.visitDate = cookie["visitDate"];
                }
            }
            return View();
        }

        public ActionResult CleanCookie()
        {
            if (Request.Cookies["cookies"]!=null)
            {
                HttpCookie cookie = Request.Cookies["cookies"];
                cookie.Expires = DateTime.Now.AddDays(-1); // dün bitmiş gibi gösteriyoruz süreyi
                Response.Cookies.Add(cookie);
                ViewBag.result = "Cookie Temizlendi";
            }
            else
            {
                ViewBag.result = "Cookie Temizlenmedi";
            }
            return View();
        }
    }
}