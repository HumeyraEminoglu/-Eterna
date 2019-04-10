using Eterna.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class AJAXController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index(string ad, string soyad)
        {
            return Content("SELAM " + ad + " " + soyad.ToUpper());
        }

        //public ActionResult Index(string ad,string soyad, int dogumYil)
        //{
        //    string rtn = "Selam: " + ad + soyad;
        //    if ((DateTime.Now.Year - dogumYil) > 35) rtn += " yolun yarısı geçilmiş";
        //    else rtn += " henüz gençsinz.";
        //    return Content(rtn);
        //}


        //public ActionResult Sehirler()
        //{
        //    string[] sehirList = { "İstanbul", "Ankara", "Konya", "Bursa", "İzmit" };

        //    return Json(sehirList, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Ilceler(string Plaka)
        {
            

            return Json(db.Ilce.Where(w=>w.SehirPlaka==Plaka), JsonRequestBehavior.AllowGet);
        }
        public ActionResult mahalleler(int ID)
        {


            return Json(db.Mahalle.Where(w => w.IlceID == ID), JsonRequestBehavior.AllowGet);
        }
    }
}