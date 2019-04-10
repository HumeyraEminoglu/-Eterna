using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.Models
{
    [Table("Mahalle")]
    public class Mahalle
    {
        public int ID { get; set; }
        [StringLength(50), Column(TypeName = "Varchar")]
        public string Ad { get; set; }
        public Ilce Ilce { get; set; }
        public int IlceID { get; set; }

    }
}