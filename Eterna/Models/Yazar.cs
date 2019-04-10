using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    [Table("Yazar")]
    public class Yazar
    {
        public int ID { get; set; }

        [StringLength(150), Column(TypeName = "Varchar")]
        public string AdSoyad { get; set; }
        public ICollection<BlogYazar> BlogYazar { get; set; }
    }
}