using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Administrator : Korisnik
    {
        private int AdministratorId;
        private List<Zahtjev> ZahtjevId;
        private bool deaktiviran;

        public int AdministratorId1 { get => AdministratorId; set => AdministratorId = value; }
        public List<Zahtjev> ZahtjevId1 { get => ZahtjevId; set => ZahtjevId = value; }
        public bool Deaktiviran { get => deaktiviran; set => deaktiviran = value; }

        public virtual Zahtjev Zahtjev { get; set; }

        public Administrator( List<Zahtjev> zahtjevId1, bool deaktiviran, Zahtjev zahtjev)
        {
           
        }
    }
}