using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace e_market.Models
{
    public class Uposlenik : Korisnik
    {
        private static int brojac = 0;

        public List<int> Zahtjevi { get; set; }
        public int lanac { get; set; }
        public int UposlenikId { get; set; }

        public int Lanac { get => lanac; set => lanac = value; }
        public virtual ICollection<int> zahtjevi { get; set; }

        public Uposlenik()
        {
            UposlenikId = brojac++;
        }

        public Uposlenik(string ime1, string prezime1, string emailAdresa1, string adresaStanovanja1, Grad grad1, Opcina opcina1, Naselje naselje1, string korisnickoIme1, string lozinka1, int lanac, List<int> zahtjevi)
            : base(ime1, prezime1, emailAdresa1, adresaStanovanja1, grad1, opcina1, naselje1, korisnickoIme1, lozinka1)
        {
            UposlenikId = brojac++;
            Zahtjevi = zahtjevi;
            Lanac = lanac;
        }
    }
}