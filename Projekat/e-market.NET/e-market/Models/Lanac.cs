using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Lanac
    {
        private String naziv;
        private List<Supermarket> SupermarketId;

        public Lanac(string naziv)
        {
            Naziv = naziv;
            SupermarketId1 = new List<Supermarket>()
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public List<Supermarket> SupermarketId1 { get => SupermarketId; set => SupermarketId = value; }

        public virtual Supermarket Supermarket { get; set; }
    }
}