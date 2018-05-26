using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    class Kontejner
    {
        public Kontejner()
        {

        }
        private static List<Klijent> korisnici = new List<Klijent>();
        private static List<Administrator> administratori = new List<Administrator>();
        private static List<Menadzer> menadzeri = new List<Menadzer>();

        public static List<Klijent> Korisnici { get => korisnici; set => korisnici = value; }
        public static List<Administrator> Administratori { get => administratori; set => administratori = value; }
        public static List<Menadzer> Menadzeri { get => menadzeri; set => menadzeri = value; }
    }
}
