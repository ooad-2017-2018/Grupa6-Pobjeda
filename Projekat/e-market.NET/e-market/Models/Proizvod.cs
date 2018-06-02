using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Proizvod
    {
        private static int brojac = 0;
        private String naziv;

        public int ProizvodId { get; set; }
        [Required]
        public string Naziv { get => naziv; set => naziv = value; }

        public Proizvod()
        {
            ProizvodId = brojac++;
        }

        public Proizvod(String naziv)
        {
            ProizvodId = brojac++;
            Naziv = naziv;
        }

    }
}