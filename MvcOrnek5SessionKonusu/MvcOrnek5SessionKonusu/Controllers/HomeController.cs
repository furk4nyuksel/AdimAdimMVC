using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek5SessionKonusu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SessionTest()
        {
            Session.Add("DateTime", DateTime.Now);
            return View();
        }
        /// register yerine login olmalıydı dalgınlığıma gelmiş kusura bakmayın.
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(string userName,string password)
        {
            SessionOrnekEntities db = new SessionOrnekEntities();

            var query = db.AppUsers.Where(s => s.UserName.Equals(userName) && s.Password.Equals(password)).SingleOrDefault();

            if (query != null)
            {
                Session.Add("LogginUser", query);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.result = "kullanıcı adı veya şifre yanlış";
                return View();
            }
        }
    }
}