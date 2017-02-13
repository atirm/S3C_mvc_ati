using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S3C_MVC.Models;

namespace S3C_MVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
           ViewBag.Title = "صفحه اخبار";
            var blogsetting = new BlogSetting();
            blogsetting.title = "اخبار";
            blogsetting.text = "   اطلاعاتی درباره پوشاک <b> " + DateTime.Now.ToShortTimeString() + "<b/>";
            return View(model: blogsetting);
        }
    }
}