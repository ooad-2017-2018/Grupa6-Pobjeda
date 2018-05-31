using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Aplikacija
    {
        private List<Lanac> LanacId;
        private List<Korisnik> KorisnikId;
        private List<Proizvod> ProizvodId;

        public List<Lanac> LanacId1 { get => LanacId; set => LanacId = value; }
        public List<Korisnik> KorisnikId1 { get => KorisnikId; set => KorisnikId = value; }
        public List<Proizvod> ProizvodId1 { get => ProizvodId; set => ProizvodId = value; }

        public Aplikacija()
        {
            LanacId = new List<Lanac>();
            KorisnikId = new List<Korisnik>();
            ProizvodId = new List<Proizvod>();
        }
        
        public virtual List<Lanac> Lanac { get; set; }
        public virtual List<Korisnik> Korisnik{ get; set; }
        public virtual List<Proizvod> Proizvod { get; set; }
    }
}