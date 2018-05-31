using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace e_market.Models
{
    public class Uposlenik : Korisnik
    {
        private int UposlenikId;
        private Lanac lanac;
        private List<Zahtjev> ZahtjevId;

        public Uposlenik(string ime1, string prezime1, string emailAdresa1, string adresaStanovanja1, Grad grad1, Opcina opcina1, Naselje naselje1, string korisnickoIme1, string lozinka1, Lanac lanac, List<Zahtjev> zahtjevi)
            : base(ime1, prezime1, emailAdresa1, adresaStanovanja1, grad1, opcina1, naselje1, korisnickoIme1, lozinka1)
        {

        }

        public int UposlenikId1 { get => UposlenikId; set => UposlenikId = value; }
        public Lanac Lanac { get => lanac; set => lanac = value; }
        public List<Zahtjev> ZahtjevId1 { get => ZahtjevId; set => ZahtjevId = value; }
    }
}