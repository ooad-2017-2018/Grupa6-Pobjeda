using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Opcina
    {
        private static int brojac = 0;
        [Required]
        public String Naziv { get; set; }

        public int OpcinaId { get; set; }
        public List<int> NaseljaId { get; set; }

        public virtual ICollection<Opcina> Opcine { get; set; }

        public Opcina()
        {
            OpcinaId = brojac++;
            NaseljaId = new List<int>();
        }

        public Opcina(String naziv, List<int> naselja)
        {
            OpcinaId = brojac++;
            Naziv = naziv;
            NaseljaId = naselja;
        }

        public void dodajNaselje(int naselje)
        {
            NaseljaId.Add(naselje);
        }
    }
}