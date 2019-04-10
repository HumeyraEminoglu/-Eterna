using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eterna.Contexts;
using Eterna.Models;
using Eterna.ViewModels;

namespace Eterna.Controllers
{
    public class BlogsController : Controller
    {
        private MyContext db = new MyContext();

        // GET: Blogs
        public ActionResult Index()
        {
            return View(db.Blog.ToList());
        }

        // GET: Blogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blog.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // GET: Blogs/Create
        public ActionResult Create()
        {
            //BlogBlogEtiket blogBlogEtiket = new BlogBlogEtiket() {
            //    Blog = new Blog(),
            //    Etiketler = db.Etiket.ToList()
            //}; 
            BlogCBList blogCBList = new BlogCBList();            
            List<OrtakCBList> etiketCBList = new List<OrtakCBList>();
            List<OrtakCBList> yazarCBList = new List<OrtakCBList>();
            foreach (Etiket etiket in db.Etiket)
            {
                etiketCBList.Add(new OrtakCBList() {
                    ID = etiket.ID,
                    Ad = etiket.Ad,
                    Secilimi = false
                });
            }
            foreach (Yazar yazar in db.Yazar)
            {
                yazarCBList.Add(new OrtakCBList()
                {
                    ID = yazar.ID,
                    Ad = yazar.AdSoyad,
                    Secilimi = false
                });
            }
            blogCBList.etiketCBLists = etiketCBList;
            blogCBList.yazarCBLists = yazarCBList;
            blogCBList.Blog = new Blog();
            return View(blogCBList);
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogCBList model)
        {
            if (ModelState.IsValid)
            {
                db.Blog.Add(model.Blog);
                db.SaveChanges();
                foreach (OrtakCBList hbc in model.etiketCBLists)
                {
                    if(hbc.Secilimi==true)
                    {
                        db.BlogEtiket.Add(new BlogEtiket { BlogID=model.Blog.ID,EtiketID=hbc.ID});
                        db.SaveChanges();
                    }
                }
                foreach (OrtakCBList hby in model.yazarCBLists)
                {
                    if (hby.Secilimi == true)
                    {
                        db.BlogYazar.Add(new BlogYazar { BlogID = model.Blog.ID, YazarID = hby.ID });
                        db.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }

            return View(model.Blog);
        }

        // GET: Blogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blog.Where(w=>w.ID==id).Include(i=>i.BlogEtiket).FirstOrDefault();
            BlogCBList blogCBList = new BlogCBList();
            blogCBList.Blog = blog;
            List<OrtakCBList> cBLists = new List<OrtakCBList>();
            foreach (Etiket hbe in db.Etiket.ToList())
            {
                cBLists.Add(new OrtakCBList()
                {
                    ID = hbe.ID,
                    Ad = hbe.Ad,
                    Secilimi = blog.BlogEtiket.Any(a=>a.EtiketID== hbe.ID)
                });
            }
            blogCBList.etiketCBLists = cBLists;
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blogCBList);
        }

        // POST: Blogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BlogCBList model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model.Blog).State = EntityState.Modified;
                db.SaveChanges();
                db.BlogEtiket.RemoveRange(db.BlogEtiket.Where(w => w.BlogID == model.Blog.ID));
                foreach (OrtakCBList hbc in model.etiketCBLists)
                {
                    if (hbc.Secilimi == true)
                    {
                        db.BlogEtiket.Add(new BlogEtiket { BlogID = model.Blog.ID, EtiketID = hbc.ID });
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index");
            }
            return View(model.Blog);
        }

        // GET: Blogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blog.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog blog = db.Blog.Find(id);
            db.Blog.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
