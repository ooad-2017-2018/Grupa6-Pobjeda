using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public abstract class Korisnik
    {
        private String ime { get; set; }
        private String prezime { get; set; }
        private String emailAdresa { get; set; }
        private String adresaStanovanja { get; set; }
        private Grad grad { get; set; }
        private Opcina opcina { get; set; }
        private Naselje naselje { get; set; }
        private String korisnickoIme { get; set; }
        private String lozinka { get; set; }

        public Korisnik() { }
        public Korisnik(String i, String p, String e, String a, Grad g, Opcina o, Naselje n, String k, String l)
        {
            ime = i; prezime = p; emailAdresa = e; adresaStanovanja = a; grad = g; opcina = o; naselje = n; korisnickoIme = k; lozinka = l;
        }

        public String getIme()
        {
            return ime;
        }
        public void setIme(String i)
        {
            ime = i;
        }

        public String getPrezime()
        {
            return prezime;
        }
        public void setPrezime(String p)
        {
            prezime = p;
        }

        public String getEmailAdresa()
        {
            return emailAdresa;
        }
        public void setEmailAdresa(String e)
        {
            emailAdresa = e;
        }

        public String getAdresaStanovanja()
        {
            return adresaStanovanja;
        }
        public void setAdresaStanovanja(String a)
        {
            adresaStanovanja = a;
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

        public String getKorisnickoIme()
        {
            return korisnickoIme;
        }
        public void setKorisnickoIme(String k)
        {
            korisnickoIme = k;
        }

        public String getLozinka()
        {
            return lozinka;
        }
        public void setLozinka(String l)
        {
            lozinka = l;
        }
    }
}
