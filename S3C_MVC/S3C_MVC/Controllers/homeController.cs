using S3C_MVC.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S3C_MVC.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {

            ViewBag.Title = "صفحه اصلی";

            var db = new EntityContext();

        var result= db.Products.ToList();
            return View(result);
        }
    }
}