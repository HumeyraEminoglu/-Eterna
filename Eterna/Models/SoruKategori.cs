using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.Models
{
    [Table("SoruKategori")]
    public class SoruKategori
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "Varchar")]
        public string Ad { get; set; }

        public ICollection<Soru> Soru { get; set; }
    }
}