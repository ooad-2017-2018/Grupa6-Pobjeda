using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace e_market.Models
{
    public class Uposlenik : Korisnik
    {
        private static int brojac = 0;

        public List<int> Zahtjevi { get; set; }
        [Required]
        public int lanac { get; set; }
        public int UposlenikId { get; set; }

        public virtual Lanac Lanac { get ; set; }
        public virtual ICollection<Zahtjev> zahtjevi { get; set; }

        public Uposlenik()
        {
            UposlenikId = brojac++;
        }

        public Uposlenik(string ime1, string prezime1, string emailAdresa1, string adresaStanovanja1, int grad1, int opcina1, int naselje1, string korisnickoIme1, string lozinka1, int lanac, List<int> zahtjevi)
            : base(ime1, prezime1, emailAdresa1, adresaStanovanja1, grad1, opcina1, naselje1, korisnickoIme1, lozinka1)
        {
            UposlenikId = brojac++;
            Zahtjevi = zahtjevi;
            this.lanac = lanac;
        }
    }
}