using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    [Table("Etiket")]
    public class Etiket
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "Varchar")]
        public string Ad { get; set; }

        public ICollection<BlogEtiket> BlogEtiket { get; set; }
    }
}