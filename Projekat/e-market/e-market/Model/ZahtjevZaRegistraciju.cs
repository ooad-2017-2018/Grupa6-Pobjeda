using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class ZahtjevZaRegistraciju : Zahtjev
    { 
        private String korisnickoIme { get; set; }

        public ZahtjevZaRegistraciju() : base() { }

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
