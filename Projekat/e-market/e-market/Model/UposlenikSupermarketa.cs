using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class UposlenikSupermarketa : Uposlenik
    {
        private int sifraSefa { get; set; }

        public UposlenikSupermarketa() : base() { }
        public UposlenikSupermarketa(String i, String p, String e, String a, Grad g, Opcina o, Naselje n, String k, String l, Lanac lan, List<Zahtjev> z, int s) : base(i, p, e, a, g, o, n, k, l, lan, z)
        {
            sifraSefa = s;
        }

        public int getSifraSefa()
        {
            return sifraSefa;
        }
    }
}
