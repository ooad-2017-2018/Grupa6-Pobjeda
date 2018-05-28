using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_market
{
    public class Kontejner
    {
        private List<Klijent> korisnici;
        private List<Administrator> administratori;
        private List<Menadzer> menadzeri;
        private List<Uposlenik> uposlenici;
        private List<Grad> _gradovi;
        private List<Supermarket> supermarketi;
        private List<Lanac> lanciSupermarketa;
        private int userLoginovan;

        public List<Klijent> Korisnici { get => korisnici; set => korisnici = value; }
        public List<Administrator> Administratori { get => administratori; set => administratori = value; }
        public List<Menadzer> Menadzeri { get => menadzeri; set => menadzeri = value; }
        public List<Uposlenik> Uposlenici { get => uposlenici; set => uposlenici = value; }
        public List<Grad> Gradovi { get => _gradovi; set => _gradovi = value; }
        public List<Supermarket> Supermarketi { get => supermarketi; set => supermarketi = value; }
        public List<Lanac> LanciSupermarketa { get => lanciSupermarketa; set => lanciSupermarketa = value; }
        public int UserLoginovan { get => userLoginovan; set => userLoginovan = value; }

        public Kontejner()
        {
            korisnici = new List<Klijent>();
            administratori = new List<Administrator>();
            administratori.Add(new Administrator("dd", "dd", "dd@gmail.com", "dd", new Grad(), new Opcina(), new Naselje(), "dd", "dd", null));
            menadzeri = new List<Menadzer>();
            uposlenici = new List<Uposlenik>();
            lanciSupermarketa = dajLanceSupermarketa();
            _gradovi = DajGradove();
        }

        public void dodajKorisnika(Klijent k)
        {
            korisnici.Add(k);
        }

        public void dodajMenadžera(Menadzer k)
        {
            menadzeri.Add(k);
        }

        public void dodajUposlenika(Uposlenik k)
        {
            uposlenici.Add(k);
        }

        public int dajUsera(String username, String password)
        {
            for (int i = 0; i < korisnici.Count; i++)
                if (korisnici[i].getKorisnickoIme() == username && korisnici[i].getLozinka() == password)
                    return 0;

            for (int i = 0; i < menadzeri.Count; i++)
                if (menadzeri[i].getKorisnickoIme() == username && menadzeri[i].getLozinka() == password)
                    return 1;

            for (int i = 0; i < uposlenici.Count; i++)
                if (uposlenici[i].getKorisnickoIme() == username && uposlenici[i].getLozinka() == password)
                    return 2;

            for (int i = 0; i < administratori.Count; i++)
                if (administratori[i].getKorisnickoIme() == username && administratori[i].getLozinka() == password)
                    return 3;

            return -1;

        }

        public int dajIndexGrada(String imeGrada)
        {
            for (int i = 0; i < _gradovi.Count; i++)
                if (_gradovi[i].getNaziv() == imeGrada)
                    return i;
            return -1;
        }
       
        private List<Lanac> dajLanceSupermarketa()
        {
            List<Lanac> lanci = new List<Lanac>();
            lanci.Add(new Lanac("Bingo"));
            lanci.Add(new Lanac("Konzum"));
            lanci.Add(new Lanac("Merkator"));
            lanci.Add(new Lanac("Hoše komerc"));
            return lanci;
        }
        private List<Grad> DajGradove()
        {
            List<Grad> gradovi = new List<Grad>();

            List<Opcina> Sarajevo = new List<Opcina>();


            List<Naselje> StariGrad = new List<Naselje>();
            StariGrad.Add(new Naselje("Stari Grad"));
            StariGrad.Add(new Naselje("Hreša"));
            StariGrad.Add(new Naselje("Barice"));
            Sarajevo.Add(new Opcina("Stari Grad", StariGrad));

            List<Naselje> Centar = new List<Naselje>();
            Centar.Add(new Naselje("Poljine"));
            Centar.Add(new Naselje("Mrkovići"));
            Centar.Add(new Naselje("Centar"));
            Sarajevo.Add(new Opcina("Centar", Centar));

            List<Naselje> NovoSarajevo = new List<Naselje>();
            NovoSarajevo.Add(new Naselje("Novo Sarajevo"));
            NovoSarajevo.Add(new Naselje("Miljevići"));
            NovoSarajevo.Add(new Naselje("Lukavica"));
            Sarajevo.Add(new Opcina("Novo Sarajevo", NovoSarajevo));

            List<Naselje> NoviGrad = new List<Naselje>();
            NoviGrad.Add(new Naselje("Bojnik"));
            NoviGrad.Add(new Naselje("Novi Grad"));
            NoviGrad.Add(new Naselje("Rečica"));
            Sarajevo.Add(new Opcina("Novi Grad", NoviGrad));

            gradovi.Add(new Grad("Sarajevo", Sarajevo));


            gradovi.Add(new Grad("Banja Luka", null));
            gradovi.Add(new Grad("Tuzla", null));
            gradovi.Add(new Grad("Zenica", null));
            gradovi.Add(new Grad("Mostar", null));
            gradovi.Add(new Grad("Istočno Sarajevo", null));
            gradovi.Add(new Grad("Prijedor", null));
            gradovi.Add(new Grad("Bijeljina", null));
            gradovi.Add(new Grad("Trebinje", null));
            gradovi.Add(new Grad("Doboj", null));
            gradovi.Add(new Grad("Široki Brijeg", null));
            gradovi.Add(new Grad("Bihać", null));
            gradovi.Add(new Grad("Zvornik", null));
            gradovi.Add(new Grad("Livno", null));
            gradovi.Add(new Grad("Cazin", null));
            gradovi.Add(new Grad("Goražde", null));


            return gradovi;
        }
    }
}
