using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class Proizvod
    {
        private String naziv { get; set; }
        private int sifraProizvoda { get; set; }

        public Proizvod() { }

        public String getNaziv()
        {
            return naziv;
        }
        public void setNaziv(String n)
        {
            naziv = n;
        }

        public int getSifraProizvoda()
        {
            return sifraProizvoda;
        }
    }
}
