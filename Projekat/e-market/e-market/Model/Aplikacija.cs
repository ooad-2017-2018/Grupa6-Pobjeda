using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public sealed class Aplikacija
    {
        private List<Lanac> lanci { get; set; }
        private List<Korisnik> korisnici { get; set; }
        private List<Proizvod> spisakProizvoda { get; set; }

        public Aplikacija() { lanci = new List<Lanac>(); korisnici = new List<Korisnik>(); spisakProizvoda = new List<Proizvod>(); }
        public Aplikacija(List<Lanac> l, List<Korisnik> k, List<Proizvod> p)
        {
            lanci = l; korisnici = k; spisakProizvoda = p;
        }

        public List<Lanac> getLanci()
        {
            return lanci;
        }
        public void setLanci(List<Lanac> l)
        {
            lanci = l;
        }

        public List<Korisnik> getKorisnici()
        {
            return korisnici;
        }
        public void setKorisnici(List<Korisnik> k)
        {
            korisnici = k;
        }

        public List<Proizvod> getSpisakPorizvoda()
        {
            return spisakProizvoda;
        }
        public void setSpisakProizvoda(List<Proizvod> p)
        {
            spisakProizvoda = p;
        }

        public void dodajKorisnika(Korisnik k)
        {
            korisnici.Add(k);
        }
        public void dodajProizvod(Proizvod p)
        {
            spisakProizvoda.Add(p);
        }
        public void dodajLanac(Lanac l)
        {
            lanci.Add(l);
        }

    }
}
