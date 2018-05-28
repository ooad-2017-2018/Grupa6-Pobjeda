using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class Administrator : Korisnik
    {
        private int sifraAdministratora { get; set; }
        private List<Zahtjev> zahtjevi { get; set; }
        public bool Deaktiviran { get => deaktiviran; set => deaktiviran = value; }
    
        private bool deaktiviran;

        public Administrator() : base()
        {
            zahtjevi = new List<Zahtjev>();
        }
        public Administrator(String i, String p, String e, String a, Grad g, Opcina o, Naselje n, String k, String l, List<Zahtjev> z) : base(i, p, e, a, g, o, n, k, l)
        {
            zahtjevi = z;
        }

        public int getSifraAdministratora()
        {
            return sifraAdministratora;
        }

        public List<Zahtjev> getZahtjevi()
        {
            return zahtjevi;
        }
        public void setZahtjevi(List<Zahtjev> z)
        {
            zahtjevi = z;
        }
        public void deaktiviraj()
        {
            deaktiviran = true;
        }
    }
}
