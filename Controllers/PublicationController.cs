using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tupperware_e_commerce.Controllers
{
    public class PublicationController : Controller
    {
        // GET: Publication
        public ActionResult Create()
        {
            return View("../Dashboard/Publication/Create");
        }
        public ActionResult Delete()
        {
            return View("../Dashboard/Publication/Delete");
        }
        public ActionResult Edit()
        {
            return View("../Dashboard/Publication/Edit");
        }
        public ActionResult Index()
        {
            return View("../Dashboard/Publication/Index");
        }
    }
}