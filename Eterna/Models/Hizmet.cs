using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.Models
{
    [Table("Hizmet")]
    public class Hizmet
    {
        public int ID { get; set; }

        [StringLength(50), Column(TypeName = "Varchar"),Display(Name ="Hizmet Adı"),Required(ErrorMessage ="Ad boş geçilemez.")]
        public string Ad { get; set; }

        public int Sira { get; set; }
    }
}