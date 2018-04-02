using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tupperware_e_commerce.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Create()
        {
            return View("../Dashboard/Client/Create");
        }
        public ActionResult Delete()
        {
            return View("../Dashboard/Client/Delete");
        }
        public ActionResult Edit()
        {
            return View("../Dashboard/Client/Edit");
        }
        public ActionResult Index()
        {
            return View("../Dashboard/Client/Index");
        }

    }
}