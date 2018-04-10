using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class Supermarket
    {
        private int sifraSupermarketa { get; set; }
        private Grad grad { get; set; }
        private Opcina opcina { get; set; }
        private Naselje naselje { get; set; }
        private List<UposlenikSupermarketa> uposlenici { get; set; }
        private Menadzer menadzer { get; set; }
        private List<Artikal> spisakArtikala { get; set; }
        private int brojLajkova { get; set; }

        public Supermarket() { uposlenici = new List<UposlenikSupermarketa>(); spisakArtikala = new List<Artikal>(); }

        public int getSifraSupermarketa ()
        {
            return sifraSupermarketa;
        }

        public Grad getGrad()
        {
            return grad;
        }
        public void setGrad(Grad g)
        {
            grad = g;
        }

        public Opcina getOpcina()
        {
            return opcina;
        }
        public void setOpcina(Opcina o)
        {
            opcina = o;
        }

        public Naselje getNaselje()
        {
            return naselje;
        }
        public void setNaselje(Naselje n)
        {
            naselje = n;
        }

        public List<UposlenikSupermarketa> getUposlenici()
        {
            return uposlenici;
        }
        public void setUposlenici(List<UposlenikSupermarketa> u)
        {
            uposlenici = u;
        }

        public Menadzer getMenadzer()
        {
            return menadzer;
        }
        public void setMenadzer(Menadzer m)
        {
            menadzer = m;
        }

        public List<Artikal> getSpisakArtikala()
        {
            return spisakArtikala;
        }
        public void setSpisakArtikala(List<Artikal> a)
        {
            spisakArtikala = a;
        }

        public int getBrojLajkova()
        {
            return brojLajkova;
        }
        public void setBrojLajkova(int b)
        {
            brojLajkova = b;
        }

        public void dodajUposlenika(UposlenikSupermarketa u)
        {
            uposlenici.Add(u);
        }
        public void dodajArtikal(Artikal a)
        {
            spisakArtikala.Add(a);
        }

        public Artikal pretraziArtikal(String n)
        {
            foreach(Artikal a in spisakArtikala)
            {
                if(a.getNaziv() == n)
                {
                    return a;
                }
            }
            return new Artikal();
        }
        public Artikal pretraziArtikal(int sifra)
        {
            foreach(Artikal a in spisakArtikala)
            {
                if(a.getSifraArtikla() == sifra)
                {
                    return a;
                }
            }
            return new Artikal();
        } 
    }
}
