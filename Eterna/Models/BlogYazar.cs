using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    [Table("BlogYazar")]
    public class BlogYazar
    {
        [Key,Column(Order =1)]
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

        [Key, Column(Order = 2)]
        public int YazarID { get; set; }
        public Yazar Yazar { get; set; }
    }
}