using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Opcina
    {
        private static int brojac = 0;
        private String naziv { get; set; }

        public int OpcinaId { get; set; }
        public List<int> NaseljaId { get; set; }

        public virtual ICollection<int> Opcine { get; set; }

        public Opcina()
        {
            OpcinaId = brojac++;
            NaseljaId = new List<int>();
        }

        public Opcina(String naziv, List<int> naselja)
        {
            OpcinaId = brojac++;
            NaseljaId = naselja;
        }

        public void dodajNaselje(int naselje)
        {
            NaseljaId.Add(naselje);
        }
    }
}