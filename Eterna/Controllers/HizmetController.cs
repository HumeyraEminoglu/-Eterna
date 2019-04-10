using Eterna.Contexts;
using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class HizmetController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index()
        {
            return View(db.Hizmet.ToList());
        }
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(string adi, int sirasi)
        {
            db.Hizmet.Add(new Hizmet { Ad = adi, Sira = sirasi });
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int ID)
        {
            return View(db.Hizmet.Where(w=>w.ID==ID).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Guncelle(int ID,string adi, int sirasi)
        {
            Hizmet hizmet = db.Hizmet.Where(w => w.ID == ID).FirstOrDefault();
            hizmet.Ad = adi;
            hizmet.Sira = sirasi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int ID)
        {
            return View(db.Hizmet.Where(w => w.ID == ID).FirstOrDefault());
        }

        public ActionResult SilEvet(int ID)
        {
            Hizmet hizmet = db.Hizmet.Where(w => w.ID == ID).FirstOrDefault();
            db.Hizmet.Remove(hizmet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}