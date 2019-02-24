using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek7GetKonusu.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db;

        public HomeController()
        {
            db = new NorthwindEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetAllCategory()
        {
            var query = db.Categories.ToList();

            return View(query);
        }
    }
}