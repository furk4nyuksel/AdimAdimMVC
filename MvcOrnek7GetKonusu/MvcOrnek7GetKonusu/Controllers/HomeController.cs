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
        //Çoklu veri
        public ActionResult GetAllCategory()
        {
            var query = db.Categories.ToList();

            return View(query);
        }
        //Tekli veri
        public ActionResult GetCategory(int Id=0)
        {
            var query = db.Categories.Where(s => s.CategoryID == Id).SingleOrDefault();
            return View(query);
        }
    }
}