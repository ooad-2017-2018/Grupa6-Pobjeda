using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Menadzer : Uposlenik
    {
        private static int brojac = 0;

        public int MenadzerId {get; set;}
        public List<Supermarket> SupermarketId { get; set; }
        public int MenadzerId { get; set; }

        public virtual ICollection<Supermarket> Supermarketi { get; set;}

        public Menadzer(): base()
        {
            MenadzerId = brojac++;
            SupermarketId = new List<Supermarket>();
        }

        public Menadzer(String ime, String prezime, String adresa, Grad grad, Opcina opcina, Naselje naselje, String korisnickoIme, String lanac, List<Zahtjev> zahtjevi, List<Supermarket> supermarketi) :
            base(ime, prezime, adresa, grad, opcina, naselje, korisnickoIme, lanac, zahtjevi)
        {
            SupermarketId = supermarketi;
            MenadzerId = brojac++;
        }

        public void dodajSupermarket(Supermarket supermarket)
        {
            SupermarketId.Add(supermarket);
        }
    }
}