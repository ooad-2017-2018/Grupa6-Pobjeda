using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Naselje
    {
        private static int brojac = 0;

        private string _naziv;
        [Required]
        public String Naziv { get => _naziv; set => _naziv = value; }
        public int NaseljeId {get; set;}

        public Naselje() { NaseljeId = brojac++; }
        public Naselje(String naselje)
        {
            Naziv = naselje;
            NaseljeId = brojac++;
        }
    }
}