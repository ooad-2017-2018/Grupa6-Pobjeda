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
        public List<int> SupermarketId { get; set; }

        public virtual ICollection<int> Supermarketi { get; set;}

        public Menadzer(): base()
        {
            MenadzerId = brojac++;
            SupermarketId = new List<int>();
        }

        public Menadzer(String ime, String prezime, String email, String adresa, Grad grad, Opcina opcina, Naselje naselje, String korisnickoIme, String lozinka, int lanac, List<int> zahtjevi, List<int> supermarketi) :
            base(ime, prezime, email, adresa, grad, opcina, naselje, korisnickoIme, lozinka, lanac, zahtjevi)
        {
            SupermarketId = supermarketi;
            MenadzerId = brojac++;
        }

        public void dodajSupermarket(int supermarket)
        {
            SupermarketId.Add(supermarket);
        }
    }
}