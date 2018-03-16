# E-Market
1. Edo Škaljo
2. Amar Luèkin
3. Kenan Saraèeviæ

## Opis teme:
E-Market je aplikacija koja korisniku omoguæava da pregleda katalog artikala svakog supermarketa u svojoj okolini.
Svrha aplikacije je promocija artikala supermarketa putem online kataloga.
Ova aplikacija korisniku omoguæava da pregleda cijene svih artikala u svim supermarketima, kao i da sastavi svoju vlastitu shopping listu pomoæu koje æe mu sistem predložiti najpovoljniju lokaciju za kupovinu.
Aplikacija pruža vlasniku supermarketa novi naèin promocije promotivnih cijena kao i jednostavnije pružanje informacija kupcima o svojim artiklima.

# Procesi
## Registracija klijenta
Korisnik unosi svoje liène podatke meðu kojima se nalazi i mjesto stanovanja koje omoguæava sistemu da pronaðe supermarkete koji su u okruženju mjesta stanovanja korisnika.
## Pretraga po artiklu
Korisnik unosi lokaciju u èijem okruženju želi pretražiti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koje sadrže traženi naziv iz svakog supermarketa. Proizvodi su sortirani po cijenu poèevši od najmanje.
## Pretraga po supermarketu (katalog)
Korisnik unosi lokaciju u èijem okruženju želi pretražiti proizvod, zatim bira supermarket èiji katalog želi da pretražuje. Sistem izlistava sve ponuðene artikle iz odabranog supermarketa, dok korisnik ima moguænost unijeti ime artikla èime bi skratio vrijeme pretrage. Za svaki artikal je ispisana cijena i kolièina.
## Sastavljanje spiska
Korisnik unosi lokaciju u èijem okruženju želi pretražiti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koji sadrže traženo ime, pa korisnik bira artikal i kolièinu i dodaje na svoj spisak. Nakon što je spisak završen korisnik dobiva listu preporuèenih supermarketa u okolini tražene lokacije sortirani po ukupnoj vrijednosti raèuna poèevši od najmanje. Ukoliko ne postoji supermarket koji zadovoljava korisnikov spisak, izlistavaju se supermarketi koji približno zadovoljavaju spisak.
## Registracija uposlenika supermarketa
Korisnik unosi svoje liène podatke, kontakt informacije i informacije o pripadajuæem supermarketu.
## Dodavanje artikla u katalog
Uposlenik supermarketa upisuje podatke o artiklu i mora odabrati pripadajuæi artikal iz baze podataka sistema, ukoliko ne postoji traženi artikal šalje zahtjev za dodavanje artikla na spisak u bazi podataka.
## Slanje zahtjeva
Uposlenik supermarketa opisuje artikal koji želi dodati u svoj katalog, zahtjev se šalje administratoru sistema. Administratog prima zahtjev i odluèi da li da prihvati ili odbije zahtjev, nakon èega se šalje obavijest uposleniku supermarketa o odluci administratora. Ukoliko je zahtjev odobren, administrator je dodao artikal u bazu podataka, a korisnik može ponovno pokušati dodati artikal u katalog supermarketa.

# Funkcionalnosti
- Moguænost prijave na aplikaciju
- CRUD moguænost za svaku ulogu
- Moguænost pretrage po imenu artikla
- Moguænost pretrage katalog supermarketa
- Sastavljanje vlastitog spiska za kupovinu
- Slanje obavještenja o akcijskim cijenama
- Dodavanje novog artikla u katalog
- Brisanje artikla iz kataloga
- Promjena cijene artikla
- Promjena kolièine artikla
- Prikaz broja pregleda kataloga supermarketa
- Pretraga supermarketa putem GPS ureðaja
(ovdje treba još dodati funkcionalnosti, proèitati projektni zadatak 2)

# Akteri
1. Klijent - Osoba koja koristi aplikaciju radi informacija oko supermarketa u svojoj okolini, kao i artikala u njihovom katalogu. Ima moguænost kreiranja vlastitog spiska kupovine pomoæu kojeg ga aplikacija obavještava o najpovoljnijim kupovnim mjestima.

2. Uposlenik supermarketa - Osoba koja radi za supermarket i upravlja katalogom i artiklima supermarketa.

3. Administrator - Osoba koja upravlja bazom podataka artikala, dodaje ili uklanja artikle. Takoðer, obraðuje zahtjeve za dodavanje novih artikala u bazu podataka.
