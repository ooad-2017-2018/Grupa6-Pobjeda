using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class Menadzer : Korisnik
    {
        private List<Supermarket> supermarketi;

        public Menadzer() : base() { supermarketi = new List<Supermarket>(); }
        public Menadzer(String i, String p, String e, String a, Grad g, Opcina o, Naselje n, String k, String l, Lanac lan, List<Zahtjev> z, List<Supermarket> s) : base(i, p, e, a, g, o, n, k, l, lan, z)
        {
            supermarketi = s;
        }

        public List<Supermarket> getSupermarketi()
        {
            return supermarketi;
        }
        public void setSupermarketi(List<Supermarket> s)
        {
            supermarketi = s;
        }

        public void dodajSupermarket(Supermarket s)
        {
            supermarketi.Add(s);
        }
    }
}
