using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tupperware_e_commerce.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult Create()
        {
            return View("../Dashboard/Sale/Create");
        }
        public ActionResult Delete()
        {
            return View("../Dashboard/Sale/Delete");
        }
        public ActionResult Edit()
        {
            return View("../Dashboard/Sale/Edit");
        }
        public ActionResult Index()
        {
            return View("../Dashboard/Sale/Index");
        }
    }
}