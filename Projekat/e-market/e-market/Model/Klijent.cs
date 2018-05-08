using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class Klijent : Korisnik
    {
        private int sifraKlijenta { get; set; }

        public Klijent() : base() { }
        public Klijent(String i, String p, String e, String a, Grad g, Opcina o, Naselje n, String k, String l) : base(i, p, e, a, g, o, n, k, l) { }

        public int getSifraKlijenta()
        {
            return sifraKlijenta;
        }
    }
}
