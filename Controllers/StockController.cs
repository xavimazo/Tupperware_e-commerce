using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tupperware_e_commerce.Controllers
{
    public class StockController : Controller
    {
        // GET: Publication
        public ActionResult Create()
        {
            return View("../Dashboard/Stock/Create");
        }
        public ActionResult Delete()
        {
            return View("../Dashboard/Stock/Delete");
        }
        public ActionResult Edit()
        {
            return View("../Dashboard/Stock/Edit");
        }
        public ActionResult Index()
        {
            return View("../Dashboard/Stock/Index");
        }
    }
}