using Eterna.Models;
using Eterna.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eterna.Contexts
{
    public class MyContext:DbContext
    {
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Soru> Soru { get; set; }
        public DbSet<SoruKategori> SoruKategori { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Etiket> Etiket { get; set; }
        public DbSet<BlogEtiket> BlogEtiket { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<BlogYazar> BlogYazar { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Mahalle> Mahalle { get; set; }
    }
}