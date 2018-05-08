using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class Grad
    {
        private String naziv { get; set; }
        private List<Opcina> opcine { get; set; }

        public Grad() { opcine = new List<Opcina>(); }
        public Grad(String n, List<Opcina> o)
        {
            naziv = n;
            opcine = o;
        }

        public String getNaziv()
        {
            return naziv;
        }
        public void setNaziv(String n)
        {
            naziv = n;
        }

        public List<Opcina> getOpcine()
        {
            return opcine;
        }
        public void setOpcine(List<Opcina> o)
        {
            opcine = o;
        }

        public void dodajOpcinu(Opcina o)
        {
            opcine.Add(o);
        }
    }
}
