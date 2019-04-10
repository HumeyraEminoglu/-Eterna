using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Personel")]
    public class Personel
    {
        public int ID { get; set; }

        [StringLength(30),Column(TypeName ="varchar")]
        public string Ad { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string Soyad { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        public string Meslek { get; set; }

        [StringLength(150), Column(TypeName = "varchar")]
        public string Resim { get; set; }

        public int Sira { get; set; }
    }
}