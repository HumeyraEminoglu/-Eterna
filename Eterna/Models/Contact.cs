using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.Models
{
    [Table("Contact")]
    public class Contact
    {
        public int ID { get; set; }

        [StringLength(50),Column(TypeName ="varchar"),Required(ErrorMessage ="Ad soyad boş geçilemez"), Display(Name = "Adınız Soyadınız")]
        public string AdSoyad { get; set; }

        [StringLength(100), Column(TypeName = "varchar"), Display(Name = "Mail Adresiniz")]
        public string Mail { get; set; }

        [StringLength(60), Column(TypeName = "varchar"), Display(Name = "Mesajınız")]
        public string Konu { get; set; }

        [StringLength(600), Column(TypeName = "varchar"), Required(ErrorMessage = "Mesaj boş geçilemez"), Display(Name = "Mesajınız")]
        public string Mesaj { get; set; }

        [DataType(DataType.DateTime),Display(Name ="Kayıt Tarihi")]
        public DateTime KayitTarih { get; set; }

        [StringLength(150), Column(TypeName = "varchar")]
        public string Resim { get; set; }

    }
}