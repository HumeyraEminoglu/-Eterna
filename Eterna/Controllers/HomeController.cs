using System.Data.Entity;
using Eterna.Contexts;
using Eterna.Models;
using Eterna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index()
        {

            ////List<Yorum> yorumlar = new List<Yorum>()
            ////{
            ////new Yorum { }
            ////};
            //List<Yorum> yorumlar = new List<Yorum>();
            //yorumlar.Add(new Yorum {
            //    AdSoyad="Hümeyra Eminoğlu",
            //    Resim ="/Content/img/2.jpg",
            //    Mesaj ="Mesaj 1",
            //    Sira =1,
            //    WebUrl ="www.abc.com"
            //});
            //yorumlar.Add(new Yorum
            //{
            //    AdSoyad = "Kübra Kayaalp",
            //    Resim = "/Content/img/4.png",
            //    Mesaj = "Mesaj 2",
            //    Sira = 2,
            //    WebUrl = "www.xyz.com"
            //});
            //yorumlar.Add(new Yorum
            //{
            //    AdSoyad = "Erkan Uci",
            //    Resim = "/Content/img/1.jpg",
            //    Mesaj = "Mesaj 3",
            //    Sira = 3,
            //    WebUrl = "www.erkan.com"
            //});
            //return View(yorumlar);
            //1. ve 2.YOL
            //ViewBag.Sehir = db.Sehir.ToList();
            //3.YOL
            ViewBag.Sehir = new SelectList(db.Sehir.ToList(), "Plaka", "Ad");
            return View(db.Yorum.ToList());
        }

        public ActionResult About()
        {
            //List<Personel> personeller = new List<Personel>() {
            //    new Personel{Ad="Tutku",Soyad="Çelik",Meslek="Mühendis",Resim="/content/img/1.jpg",Sira=1},
            //    new Personel{Ad="Mücahit",Soyad="Hamarat",Meslek="Kuaför",Resim="/content/img/2.jpg",Sira=2},
            //    new Personel{Ad="Melike",Soyad="Alptekin",Meslek="Bakkal",Resim="/content/img/3.jpg",Sira=3},
            //    new Personel{Ad="Ümran",Soyad="Çakal",Meslek="Diyetisyen",Resim="/content/img/4.png",Sira=4}
            //};
            return View();
        }

        public ActionResult Contact()
        {
            //int yas = 50;
            ////ViewBag.AdSoyad = "Bekir <strong>OTURAKÇI</strong>";
            //ViewData["AdSoyad"] = "Bekir <strong>OTURAKÇI</strong>";
            //return View(yas);
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact modelim,HttpPostedFileBase Resim)
        {
            if(Resim!=null)
            {
                Resim.SaveAs(Server.MapPath("~/Content/img/" + Path.GetFileName(Resim.FileName)));
                modelim.Resim = "/Content/img/" + Path.GetFileName(Resim.FileName);
            }
            modelim.KayitTarih = DateTime.Now;
            db.Contact.Add(modelim);
            db.SaveChanges();
            return View();
        }

        public ActionResult Gonder(Contact modelim)
        {
            modelim.KayitTarih = DateTime.Now;
            db.Contact.Add(modelim);
            db.SaveChanges();
            //Mail Gönderme işlemleri
            TempData["Gönderildi"] = "Mesajınız Başarıyla Gönderildi";
            return RedirectToAction("Contact");
        }

        public ActionResult Reference()
        {
            ViewBag.MenuIndex = 4;
            return View();
        }
        public ActionResult SSS()
        {
            ViewBag.MenuIndex = 3;
            return View(db.SoruKategori.Include("Soru").ToList());
        }
        public ActionResult Menu()
        {
            return PartialView(db.Hizmet.ToList());
        }
        public ActionResult SabitIcerik()
        {
            //string isim = "Melike";
            int yas = 50;
           // return PartialView("SabitIcerik", isim);
            return PartialView(yas);
        }
        public ActionResult SoruBasliklari()
        {
            //ICollection<SoruKategori> sk = db.SoruKategori.Include(i => i.Soru).ToList(); using System.Data.Entity;
            return PartialView(db.SoruKategori.ToList());
        }
    }
    public class UlkeSehirIlce
    {
        public string[] Ulke { get; set; }
        public string[] Sehir { get; set; }
        public string[] Ilce { get; set; }
        public int Yil { get; set; }
    }
}