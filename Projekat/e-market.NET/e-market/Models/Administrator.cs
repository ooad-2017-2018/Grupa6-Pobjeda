using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Administrator : Korisnik
    {
        private static int brojac = 0;
        private bool deaktiviran;

        public int AdministratorId { get; set; }
        public List<int> ZahtjevId { get; set; }
        public bool Deaktiviran { get => deaktiviran; set => deaktiviran = value; }

        public virtual ICollection<int> Zahtjevi { get; set; }

        public Administrator(): base()
        {
            AdministratorId = brojac++;
            ZahtjevId = new List<int>();
        }

        public Administrator(String ime, String prezime, String email, String adresa, int grad, int opcina, int naselje, String korisnickoIme, String lozinka, List<int> zahtjevi): 
            base(ime, prezime, email, adresa, grad, opcina, naselje, korisnickoIme, lozinka)
        {
            ZahtjevId = zahtjevi;
            deaktiviran = false;
            AdministratorId = brojac++;
        }

        public void dodajZahtjev(int zahtjev)
        {
            ZahtjevId.Add(zahtjev);
        }
    }
}