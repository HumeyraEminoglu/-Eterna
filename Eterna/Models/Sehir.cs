using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.Models
{
    [Table("Sehir")]
    public class Sehir
    {
        [StringLength(50), Column(TypeName = "Varchar")]
        public string Ad { get; set; }

        [Key]
        public string Plaka { get; set; }
        
        public ICollection<Ilce> Ilce { get; set; }
    }
}