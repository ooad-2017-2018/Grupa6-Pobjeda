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

        public Opcina OpcinaId { get; set; }
        public List<Naselje> NaseljaId { get; set; }

        public virtual ICollection<Opcina> Opcine { get; set; }

        public Opcina()
        {
            OpcinaId = brojac++;
            NaseljaId = new List<Naselje>();
        }

        public Opcina(String naziv, List<Naselje> naselja)
        {
            OpcinaId = brojac++;
            NaseljaId = naselja;
        }

        public void dodajNaselje(Naselje naselje)
        {
            NaseljaId.Add(naselje);
        }
    }
}