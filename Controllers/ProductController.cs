using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tupperware_e_commerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Create()
        {
            return View("../Dashboard/Product/Create");
        }
        public ActionResult Delete()
        {
            return View("../Dashboard/Product/Delete");
        }
        public ActionResult Edit()
        {
            return View("../Dashboard/Product/Edit");
        }
        public ActionResult Index()
        {
            return View("../Dashboard/Product/Index");
        }
    }
}