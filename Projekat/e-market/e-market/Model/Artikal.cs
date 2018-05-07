using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class Artikal
    {
        private String naziv { get; set; }
        private double cijena { get; set; } 
        private int kolicina { get; set; }
        private int sifraProizvoda { get; set; }
        private int sifraArtikla { get; set; }

        public Artikal() { }
        public Artikal(String n, double c, int k)
        {
            naziv = n; cijena = c; kolicina = k;
        }

        public String getNaziv()
        {
            return naziv;
        }
        public void setNaziv(String n)
        {
            naziv = n;
        }

        public double getCijena()
        {
            return cijena;
        }
        public void setCijena(double c)
        {
            cijena = c;
        }

        public int getKolicina()
        {
            return kolicina;
        }
        public void setKolicina(int k)
        {
            kolicina = k;
        }

        public int getSifraProizvoda()
        {
            return sifraProizvoda;
        }

        public int getSifraArtikla()
        {
            return sifraArtikla;
        }

        public double izracunajCijenu(int k)
        {
            return k * cijena;
        }
    }
}
