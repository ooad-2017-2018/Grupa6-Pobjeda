using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Artikal
    {
        private static int brojac = 0;

        private String naziv;
        private double cijena;
        private int kolicina;

        public int ProizvodId { get; set; }
        public int ArtikalId { get; set; }

        public string Naziv { get => naziv; set => naziv = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }

        public virtual Proizvod Proizvod { get; set; }

        public Artikal()
        {
            ArtikalId = brojac++;
        }

        public Artikal(String naziv, double cijena, int kolicina)
        {
            ArtikalId = brojac++;
            this.Naziv = naziv;
            this.Cijena = cijena;
            this.Kolicina = kolicina;
        } 

        public double izracunajCijenu(int kolicina)
        {
            return kolicina * cijena;
        }
    }
}