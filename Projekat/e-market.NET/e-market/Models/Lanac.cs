using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Lanac
    {
        private static int brojac = 0;
        private String naziv;

        public int LanacId {get; set;}
        public string Naziv { get => naziv; set => naziv = value; }
        public List<int> SupermarketId { get; set; }

        public virtual ICollection<int> Supermarket { get; set; }

        public Lanac(string naziv)
        {
            LanacId = brojac++;
            Naziv = naziv;
            SupermarketId = new List<int>();
        }

        public void dodajSupermarket(int supermarket)
        {
            SupermarketId.Add(supermarket);
        }
    }
}