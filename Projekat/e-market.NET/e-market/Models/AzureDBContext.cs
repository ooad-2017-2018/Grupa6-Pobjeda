using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace e_market.Models
{
    public class AzureDBContext : DbContext
    {
        public AzureDBContext() : base("AzureConnection")
        {

        }
            public DbSet<Korisnik> Korisnik { get; set; }
            public DbSet<Administrator> Administrator { get; set; }
            public DbSet<Artikal> Artikal { get; set; }
            public DbSet<Grad> Grad { get; set; }
            public DbSet<Klijent> Klijent { get; set; }
            public DbSet<Lanac> Lanac { get; set; }
            public DbSet<Menadzer> Menadzer { get; set; }
            public DbSet<Naselje> Naselje { get; set; }
            public DbSet<Opcina> Opcina { get; set; }
            public DbSet<Proizvod> Proizvod { get; set; }
            public DbSet<Supermarket> Supermarket { get; set; }
            public DbSet<Uposlenik> Uposlenik { get; set; }
            public DbSet<UposlenikSupermarketa> UposlenikSupermarketa { get; set; }
            public DbSet<Zahtjev> Zahtjev { get; set; }
            public DbSet<ZahtjevZaDodavanjeArtikla> ZahtjevZaDodavanjeArtikla { get; set; }
            public DbSet<ZahtjevZaRegistraciju> ZahtjevZaRegistraciju { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}