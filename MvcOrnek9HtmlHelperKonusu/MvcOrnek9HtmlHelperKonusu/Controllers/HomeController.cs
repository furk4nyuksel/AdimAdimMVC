using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOrnek9HtmlHelperKonusu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public  ActionResult GetAllList()
        {
            List<SelectListItem> listSelect = new List<SelectListItem>();

            for (int i = 0; i <= 500; i++)
            {
                listSelect.Add(new SelectListItem()
                {
                    Text=i+Guid.NewGuid().ToString().Substring(0,5),
                    Value=i.ToString(),
                });
            }

            return View(listSelect);
        }
        public ActionResult GetData(int id = 0)
        {
            return View();
        }
    }
}