using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class Zahtjev
    {
        private int sifraZahtjeva { get; set; }
        private String opis { get; set; }
        private bool status { get; set; }
        private Uposlenik posiljalac { get; set; }
        private Administrator primalac { get; set; }

        public Zahtjev() { }
        
        public int getSifraZahtjeva()
        {
            return sifraZahtjeva;
        }

        public String getOpis()
        {
            return opis;
        }
        public void setOpis(String o)
        {
            opis = o;
        }

        public bool getStatus()
        {
            return status;
        }
        public void setStatus(bool s)
        {
            status = s;
        }
    }
}
