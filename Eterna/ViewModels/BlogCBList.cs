using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    public class BlogCBList
    {
        public Blog Blog { get; set; }
        public List<OrtakCBList> etiketCBLists { get; set; }
        public List<OrtakCBList> yazarCBLists { get; set; }
    }
}