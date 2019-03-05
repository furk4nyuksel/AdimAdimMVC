using MvcOrnek11CustomModelKonusu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek11CustomModelKonusu.Controllers
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
            AppUserModel model = new AppUserModel()
            {
                UserId = 1,
                UserName = "ibanez75612",
                Password = "12345",
                Email = "ibanez75612@tht.com",
                IsActive = true,
                IsDeleted = false,
            };
            List<AppUserModel> modelList = new List<AppUserModel>();
            modelList.Add(model);
            return View();
        }

        public ActionResult GetAll()
        {
            GetManyTableModel model = new GetManyTableModel();

            model.Categories = db.Categories.ToList();
            model.Products = db.Products.ToList();
            model.Shippers = db.Shippers.ToList();

            return View(model);
        }
    }
}