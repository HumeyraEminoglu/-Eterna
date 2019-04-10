using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    public class BlogBlogEtiket
    {
        public Blog Blog { get; set; }
        public List<Etiket> Etiketler { get; set; }
        public List<Yazar> Yazarlar { get; set; }

    }
}