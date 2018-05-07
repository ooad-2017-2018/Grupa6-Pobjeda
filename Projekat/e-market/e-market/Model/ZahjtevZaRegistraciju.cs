using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class ZahjtevZaRegistraciju : Zahtjev
    { 
        private String korisnickoIme { get; set; }

        public ZahjtevZaRegistraciju() : base() { }

        public String getKorisnickoIme()
        {
            return korisnickoIme;
        }
        public void setKorisnickoIme(String k)
        {
            korisnickoIme = k;
        }
    }
}
