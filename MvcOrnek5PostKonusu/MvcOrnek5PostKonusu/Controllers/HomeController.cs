using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek5PostKonusu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string userName,string email,string password)
        {
            PostMvcEntities db = new PostMvcEntities();
            AppUser adduUserModel = new AppUser()
            {
                UserName=userName,
                Email=email,
                IsActive=true,
                IsDeleted=false,
                Password=password
            };

            db.AppUser.Add(adduUserModel);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}