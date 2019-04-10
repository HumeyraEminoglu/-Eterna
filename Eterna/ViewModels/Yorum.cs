using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Yorum")]
    public class Yorum
    {
        public int ID { get; set; }

        [StringLength(50),Column(TypeName ="varchar")]
        public string AdSoyad { get; set; }

        [StringLength(50), Column(TypeName = "varchar")]
        public string Resim { get; set; }

        [StringLength(250), Column(TypeName = "varchar")]
        public string Mesaj { get; set; }

        [StringLength(150), Column(TypeName = "varchar")]
        public string WebUrl { get; set; }

        public int Sira { get; set; }
    }
}