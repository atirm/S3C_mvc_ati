using S3C_MVC.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S3C_MVC.Areas.Admin.Controllers
{
    public class Product2ManagerController : Controller
    {
        // GET: Admin/Product2Manager
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                var random = new Random();
            var image= Request.Files["Image"];
                var path = Server.MapPath("~/Upload/");
             var filename=random.Next(1000,9999)+ ".jpg";
                image.SaveAs(path + filename);
                product.Image = filename;
                var db = new EntityContext();
                db.Products.Add(product);
                db.SaveChanges();
            }
            return View();
        }
    }
}
