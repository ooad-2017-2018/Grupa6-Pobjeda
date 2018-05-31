using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Zahtjev
    {
        private static int brojac = 0;
        private String opis;
        private bool status;

        public int ZahtjevId { get; set; }
        public int UposlenikId { get; set; }
        public int AdministratorId { get; set; }
        public string Opis { get => opis; set => opis = value; }
        public bool Status { get => status; set => status = value; }

        public virtual Uposlenik Uposlenik { get; set; }
        public virtual Administrator Administrator { get; set; }

        public Zahtjev()
        {
            ZahtjevId = brojac++;
        }
        
        public Zahtjev(int UposlenikId, int AdministratorId, string Opis)
        {
            ZahtjevId = brojac++;
            this.UposlenikId = UposlenikId;
            this.AdministratorId = AdministratorId;
            this.Opis = Opis;
            Status = false;
        }

        public void prihvatiZahtjev()
        {
            Status = true;
        }
    }
}