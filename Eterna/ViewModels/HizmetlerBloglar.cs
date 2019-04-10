using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    public class HizmetlerBloglar
    {
        public ICollection<Hizmet> Hizmetler { get; set; }
        public ICollection<Blog> Bloglar { get; set; }
    }
}