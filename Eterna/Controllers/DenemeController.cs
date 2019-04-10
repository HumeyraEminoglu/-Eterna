using Eterna.Contexts;
using Eterna.Models;
using Eterna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class DenemeController : Controller
    {
        public ActionResult Index()
        {
            Deneme d = new Deneme();
            d.secilimi = true;
            return View(d);
        }
        public ActionResult IcerikVer(string ad,string soyad)
        {
            List<Sehir> sehirler = new List<Sehir>() {
                new Sehir{ID=1,Ad="Urfa" },
                new Sehir{ID=2,Ad="İstanbul" },
                new Sehir{ID=3,Ad="Ankara" },
            };
            return Json(sehirler, JsonRequestBehavior.AllowGet);
        }

    }
    class Sehir
    {
        public int ID { get; set; }
        public string Ad { get; set; }
    }
}