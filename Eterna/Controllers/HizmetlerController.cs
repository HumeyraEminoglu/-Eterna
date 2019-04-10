using Eterna.Contexts;
using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class HizmetlerController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index()
        {
            return View(db.Hizmet.ToList());
        }
        public ActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniKayit(Hizmet model)
        {
            db.Hizmet.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            return View(db.Hizmet.ToList());
        }
    }
}