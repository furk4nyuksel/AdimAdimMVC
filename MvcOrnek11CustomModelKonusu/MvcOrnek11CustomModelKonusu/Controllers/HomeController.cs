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
        // GET: Home
        public ActionResult Index()
        {
            AppUserModel model = new AppUserModel()
            {
                UserId = 1
                UserName = "ibanez75612",
                Password = "12345",
                Email = "ibanez75612@tht.com",
                IsActive = true,
                IsDeleted = false,
            };
            List<>
            List<AppUserModel> modelList = new List<AppUserModel>();
            modelList.Add(model);
            return View();
        }
    }
}