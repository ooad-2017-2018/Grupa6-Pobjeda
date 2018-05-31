using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Aplikacija
    {
        public List<Lanac> LanacId { get; set; }
        public List<Korisnik> KorisnikId { get; set; }
        public List<Proizvod> ProizvodId { get; set; }

        public virtual ICollection<Lanac> Lanci { get; set; }
        public virtual ICollection<Korisnik> Korisnici { get; set; }
        public virtual ICollection<Proizvod> Proizvodi { get; set; }

        public Aplikacija()
        {
            LanacId = new List<Lanac>();
            KorisnikId = new List<Korisnik>();
            ProizvodId = new List<Proizvod>();
        }

        public void dodajKorisnika(Korisnik korisnik)
        {
            KorisnikId.Add(korisnik);
        }

        public void dodajProizvod(Proizvod proizvod)
        {
            ProizvodId.Add(proizvod);
        }

        public void dodajLanac(Lanac lanac)
        {
            LanacId.Add(lanac);
        }
    }
}