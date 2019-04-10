using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.Models
{
    [Table("Ilce")]
    public class Ilce
    {
        public int ID { get; set; }
        [StringLength(50), Column(TypeName = "Varchar")]
        public string Ad { get; set; }
        public Sehir Sehir { get; set; }
        public string SehirPlaka { get; set; }
        public ICollection<Mahalle> Mahalle { get; set; }
    }
}