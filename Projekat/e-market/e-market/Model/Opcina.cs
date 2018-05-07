using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market.Klase
{
    public class Opcina
    {
        private String naziv { get; set; }
        private List<Naselje> naselja { get; set; }

        public Opcina() { naselja = new List<Naselje>(); }
        public Opcina(List<Naselje> n)
        {
            naselja = n;
        }

        public String getNaziv()
        {
            return naziv;
        }
        public void setNaziv(String n)
        {
            naziv = n;
        }

        public List<Naselje> getNaselja()
        {
            return naselja;
        }
        public void setNaselja(List<Naselje> n)
        {
            naselja = n;
        }

        public void dodajNaselje(Naselje n)
        {
            naselja.Add(n);
        }
    }
}
