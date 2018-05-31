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
        public List<Zahtjev> ZahtjevId { get; set; }
        public bool Deaktiviran { get => deaktiviran; set => deaktiviran = value; }

        public virtual ICollection<Zahtjev> Zahtjevi { get; set; }

        public Administrator(): base()
        {
            AdministratorId = brojac++;
            ZahtjevId = new List<Zahtjev>();
        }

        public Administrator(String ime, String prezime, String adresa, Grad grad, Opcina opcina, Naselje naselje, String korisnickoIme, String lanac, List<Zahtjev> zahtjevId1): 
            base(ime, prezime, adresa, grad, opcina, naselje, korisnickoIme, lanac)
        {
            ZahtjevId = zahtjevId1;
            deaktiviran = false;
            AdministratorId = brojac++;
        }

        public void dodajZahtjev(Zahtjev zahtjev)
        {
            ZahtjevId.Add(zahtjev);
        }
    }
}