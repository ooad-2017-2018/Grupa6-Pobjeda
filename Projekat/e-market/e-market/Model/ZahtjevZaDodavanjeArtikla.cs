using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class ZahtjevZaDodavanjeArtikla : Zahtjev
    {
        private String nazivArtikla { get; set; }

        public ZahtjevZaDodavanjeArtikla() : base() { }

        public String getNazivArtikla()
        {
            return nazivArtikla;
        }
        public void setNazivArtikla(String n)
        {
            nazivArtikla = n;
        }
    }
}
