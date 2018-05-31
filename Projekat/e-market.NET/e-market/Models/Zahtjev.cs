using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Zahtjev
    {
        private int ZahtjevId;
        private String opis;
        private bool status;
        private Uposlenik UposlenikId;
        private Administrator AdministratorId;

        public int ZahtjevId1 { get => ZahtjevId; set => ZahtjevId = value; }
        public string Opis { get => opis; set => opis = value; }
        public bool Status { get => status; set => status = value; }
        public Uposlenik UposlenikId1 { get => UposlenikId; set => UposlenikId = value; }
        public Administrator AdministratorId1 { get => AdministratorId; set => AdministratorId = value; }

        public virtual Uposlenik Uposlenik { get; set; }
        public virtual Administrator Administrator { get; set; }
    }
}