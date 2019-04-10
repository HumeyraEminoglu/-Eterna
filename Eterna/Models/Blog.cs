using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    [Table("Blog")]
    public class Blog
    {
        public int ID { get; set; }

        [StringLength(150), Column(TypeName = "Varchar")]
        public string Baslik { get; set; }

        [StringLength(150), Column(TypeName = "Varchar")]
        public string Resim { get; set; }
        
        [StringLength(500), Column(TypeName = "Varchar")]
        public string Aciklama { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime KayitTarih { get; set; }

        public ICollection<BlogEtiket> BlogEtiket { get; set; }
        public ICollection<BlogYazar> BlogYazar { get; set; }
    }
}