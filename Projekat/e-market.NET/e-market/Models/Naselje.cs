using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Naselje
    {
        private static int brojac = 0;

        private string _naziv;
        public String naziv { get => _naziv; set => _naziv = value; }
        public int NaseljeId {get; set;}

        public Naselje() { NaseljeId = brojac++; }
        public Naselje(String naselje)
        {
            naziv = naselje;
            NaseljeId = brojac++;
        }
    }
}