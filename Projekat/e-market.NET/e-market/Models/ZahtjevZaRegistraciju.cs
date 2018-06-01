using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class ZahtjevZaRegistraciju: Zahtjev
    {
        private static int brojac = 0;
        
        public int ZahtjevZaRegistracijuId { get; set; }

        public ZahtjevZaRegistraciju(int UposlenikId, int AdministratorId, string Opis, Uposlenik u) : base(UposlenikId, AdministratorId, Opis)
        {
            ZahtjevZaRegistracijuId = brojac++;
            Uposlenik = u;
        }
    }
}