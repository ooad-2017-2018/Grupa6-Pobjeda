using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public abstract class Korisnik
    {

        private static int brojac = 0;
        [Required]
        private String ime;
        [Required]
        private String prezime;
        [Required]
        private String emailAdresa;
        [Required]
        private String adresaStanovanja;
        [Required]
        private int grad;
        [Required]
        private int opcina;
        [Required]
        private int naselje;
        [Required]
        private String korisnickoIme;
        [Required]
        private String lozinka;
        [Required]
        public int KorisnikId {get; set;}
        [Required]
        public string Ime { get => ime; set => ime = value; }
        [Required]
        public string Prezime { get => prezime; set => prezime = value; }
        [Required]
        public string EmailAdresa { get => emailAdresa; set => emailAdresa = value; }
        [Required]
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        [Required]
        public int Grad { get => grad; set => grad = value; }
        [Required]
        public int Opcina { get => opcina; set => opcina = value; }
        [Required]
        public int Naselje { get => naselje; set => naselje = value; }
        [Required]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [Required]
        public string Lozinka { get => lozinka; set => lozinka = value; }

        public Korisnik() { }
        public Korisnik(string ime, string prezime, string emailAdresa, string adresaStanovanja, int grad, int opcina, int naselje, string korisnickoIme, string lozinka)
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