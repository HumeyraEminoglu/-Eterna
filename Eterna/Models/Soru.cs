using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    [Table("Soru")]
    public class Soru
    {
        public int ID { get; set; }

        [StringLength(150), Column(TypeName = "Varchar")]
        public string Ad { get; set; }

        [StringLength(500), Column(TypeName = "Varchar")]
        public string Cevap { get; set; }

        public int SoruKategoriID { get; set; }

        public SoruKategori SoruKategori { get; set; }
    }
}