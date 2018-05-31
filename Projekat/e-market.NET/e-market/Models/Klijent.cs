using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Klijent: Korisnik
    {
        private static int brojac = 0;
        public int KlijentId { get; set; }

        public Klijent(): base { }
        public Klijent(String ime, String prezime, String adresa, Grad grad, Opcina opcina, Naselje naselje, String korisnickoIme, String lanac): 
            base(ime, prezime, adresa, grad, opcina, naselje, korisnickoIme, lanac)
        {
            KlijentId = brojac++;
        }
    }
}