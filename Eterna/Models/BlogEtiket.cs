using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    [Table("BlogEtiket")]
    public class BlogEtiket
    {
        [Key,Column(Order =1)]
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

        [Key, Column(Order = 2)]
        public int EtiketID { get; set; }
        public Etiket Etiket { get; set; }
    }
}