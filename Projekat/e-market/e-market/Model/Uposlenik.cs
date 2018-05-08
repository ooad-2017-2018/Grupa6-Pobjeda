using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public abstract class Uposlenik : Korisnik
    {
        private int sifraUposlenika { get; set; }
        private Lanac lanac { get; set; }
        private List<Zahtjev> zahtjevi { get; set; }

        public Uposlenik() : base() { zahtjevi = new List<Zahtjev>(); }
        public Uposlenik(String i, String p, String e, String a, Grad g, Opcina o, Naselje n, String k, String l, Lanac lan, List<Zahtjev> z) : base(i, p, e, a ,g ,o, n, k ,l)
        {
            lanac = lan; zahtjevi = z;
        }
        
        public int getSifraUposlenika()
        {
            return sifraUposlenika;
        }

        public Lanac getLanac()
        {
            return lanac;
        }
        public void setLanac(Lanac l)
        {
            lanac = l;
        } 

        public List<Zahtjev> getZahtjevi()
        {
            return zahtjevi;
        }
        public void setZahtjevi(List<Zahtjev> z)
        {
            zahtjevi = z;
        }
    }
}
