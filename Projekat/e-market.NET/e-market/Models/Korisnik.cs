using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public abstract class Korisnik
    {

        private static int brojac = 0;
        private String ime;
        private String prezime;
        private String emailAdresa;
        private String adresaStanovanja;
        private Grad grad;
        private Opcina opcina;
        private Naselje naselje;
        private String korisnickoIme;
        private String lozinka;

        public int KorisnikId {get; set;}
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string EmailAdresa { get => emailAdresa; set => emailAdresa = value; }
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public Grad Grad { get => grad; set => grad = value; }
        public Opcina Opcina { get => opcina; set => opcina = value; }
        public Naselje Naselje { get => naselje; set => naselje = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }

        public Korisnik(string ime, string prezime, string emailAdresa, string adresaStanovanja, Grad grad, Opcina opcina, Naselje naselje, string korisnickoIme, string lozinka)
        {
            KorisnikId = brojac++;
            this.ime = ime;
            this.prezime = prezime;
            this.emailAdresa = emailAdresa;
            this.adresaStanovanja = adresaStanovanja;
            this.grad = grad;
            this.opcina = opcina;
            this.naselje = naselje;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }
    }
}