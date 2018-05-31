using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class ZahtjevZaRegistraciju: Zahtjev
    {
        private static int brojac = 0;

        public int UposlenikId { get; set; }
        public int ZahtjevZaRegistracijuId { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }

        public ZahtjevZaRegistraciju(int UposlenikId) : base()
        {
            ZahtjevZaRegistracijuId = brojac++;
            this.UposlenikId = UposlenikId;
        }
    }
}