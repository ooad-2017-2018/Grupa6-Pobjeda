using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public sealed class Lanac
    {
        private String naziv { get; set; }
        private List<Supermarket> supermarketi { get; set; }

        public Lanac() { supermarketi = new List<Supermarket>(); }

        public String getNaziv()
        {
            return naziv;
        }
        public void setNaziv(String n)
        {
            naziv = n;
        }

        public List<Supermarket> getSupermarketi()
        {
            return supermarketi;
        }
        public void getSupermarketi(List<Supermarket> s)
        {
            supermarketi = s;
        }

        public void dodajSupermarket(Supermarket s)
        {
            supermarketi.Add(s);
        }
    }
}
