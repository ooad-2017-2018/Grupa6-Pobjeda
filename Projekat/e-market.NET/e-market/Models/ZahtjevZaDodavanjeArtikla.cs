﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class ZahtjevZaDodavanjeArtikla: Zahtjev
    {
        private static int brojac = 0;
        [Required]
        public int ZahtjevZaDodavanjeArtiklaId { get; set; }
        [Required]
        public int ArtikalId { get; set; }
        public virtual Artikal Artikal { get; set; }

        public ZahtjevZaDodavanjeArtikla(int UposlenikId, int AdministratorId, string Opis, int ArtikalId) : base(UposlenikId, AdministratorId, Opis)
        {
            ZahtjevZaDodavanjeArtiklaId = brojac++;
            this.ArtikalId = ArtikalId;
        }
    }
}