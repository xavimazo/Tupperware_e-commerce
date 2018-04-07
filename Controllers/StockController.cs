using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var model = new Stock();
            return View("../Dashboard/Stock/Create", model);
        }

        [HttpPost]
        public ActionResult Create(Stock stock)
        {
            using (var db = new TupperwareContext())
            {
                db.Stock.Add(stock);
                db.SaveChanges();
            }
            Session["Message"] = "El stock fue guardado exitosamente";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            using (var db = new TupperwareContext())
            {
                var stock = db.Stock.Find(Id);
                return View("../Dashboard/Stock/Delete", stock);
            }
        }

        public ActionResult DeleteConfirmation(int id)
        {
            using (var db = new TupperwareContext())
            {
                var StockToRemove = db.Stock.Find(id);
                db.Stock.Remove(StockToRemove);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var db = new TupperwareContext())
            {
                var stock = db.Stock.Find(id);
                return View("../Dashboard/Stock/Edit");
            }
        }

        [HttpPost]
        public ActionResult Edit(Stock stock)
        {
            using (var db = new TupperwareContext())
            {
                var StockToEdit = db.Stock.Find(stock.Id);
                db.Entry(StockToEdit).CurrentValues.SetValues(stock);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var stock = new List<Stock>();
            using (var db = new TupperwareContext())
            {
               stock = db.Stock.ToList();
            }
            return View("../Dashboard/Stock/Index", stock);
        }
    }
}