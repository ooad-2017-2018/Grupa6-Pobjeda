using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class Naselje
    {
        private String naziv { get; set; }

        public Naselje() { }
        public Naselje(String n)
        {
            naziv = n;
        }

        public String getNaziv()
        {
            return naziv;
        }
        public void setNaziv(String n)
        {
            naziv = n;
        }
    }
}
