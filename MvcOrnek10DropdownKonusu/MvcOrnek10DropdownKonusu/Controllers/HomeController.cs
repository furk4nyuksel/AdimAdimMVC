using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek10DropdownKonusu.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db;
        public HomeController()
        {
            db = new NorthwindEntities();
        }   
        // GET: Home
        //Ornek 1
        public ActionResult Index()
        {
            ViewBag.ddlData = db.Categories.ToList();
            return View();
        }
       
        //Ornek2
        public ActionResult Ornek2()
        {
            SelectList selectlist = new SelectList(db.Categories.ToList(), "CategoryID", "CategoryName");
            ViewBag.ddlData = selectlist;
            return View();
        }
    }
}