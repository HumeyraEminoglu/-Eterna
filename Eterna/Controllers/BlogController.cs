using Eterna.Contexts;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class BlogController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index()
        {
            ViewBag.MenuIndex = 5;
            //return View(db.Blog.Include("BlogEtiket").Include("BlogEtiket.Etiket").ToList());
            return View(db.Blog.Include(i=>i.BlogEtiket.Select(s=>s.Etiket)).ToList());
        }
    }
}