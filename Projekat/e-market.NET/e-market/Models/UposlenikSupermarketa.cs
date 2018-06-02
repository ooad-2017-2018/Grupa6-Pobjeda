using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class UposlenikSupermarketa: Uposlenik
    {
        private static int brojac = 0;

        [Required]
        public int MenadzerId { get; set; }
        public int UposlenikSupermarketaId { get; set; }

        public virtual Menadzer Menadzer { get; set; }


        public UposlenikSupermarketa() : base()
        {
            UposlenikSupermarketaId = brojac++;
        }
        public UposlenikSupermarketa(string ime1, string prezime1, string emailAdresa1, string adresaStanovanja1, int grad1, int opcina1, int naselje1, string korisnickoIme1, string lozinka1, int lanac, List<int> zahtjevi, int MenadzerId)
            : base(ime1, prezime1, emailAdresa1, adresaStanovanja1, grad1, opcina1, naselje1, korisnickoIme1, lozinka1, lanac, zahtjevi)
        {
            UposlenikSupermarketaId = brojac++;
            this.MenadzerId = MenadzerId;
        }

     
    }
}