﻿

# **E-Market**
![alt tag](/e-market.png "e-market")

## Članovi tima:

1. Edo Škaljo
2. Amar Lučkin
3. Kenan Saračević

## Opis teme:
E-Market je aplikacija koja korisniku omogućava da pregleda katalog artikala svakog supermarketa u svojoj okolini.
Svrha aplikacije je promocija artikala supermarketa putem online kataloga.
Ova aplikacija korisniku omogućava da pregleda cijene svih artikala u svim supermarketima, kao i da kreira svoju vlastitu shopping listu pomoću koje će mu sistem predložiti najpovoljniju lokaciju za kupovinu.
Aplikacija pruža vlasniku supermarketa novi način promocije promotivnih cijena kao i jednostavnije pružanje informacija kupcima o svojim artiklima.

# Procesi
## Registracija klijenta
Korisnik unosi svoje lične podatke među kojima se nalazi i mjesto stanovanja koje omogućava sistemu da pronađe supermarkete koji su u okruženju mjesta stanovanja korisnika.
## Pretraga po artiklu
Korisnik unosi lokaciju u čijem okruženju želi pretražiti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koje sadrže traženi naziv iz svakog supermarketa. Proizvodi su sortirani po cijeni počevši od najmanje.
## Pretraga po supermarketu (katalog)
Korisnik unosi lokaciju u čijem okruženju želi pretražiti proizvod, zatim bira supermarket čiji katalog želi da pretražuje. Sistem izlistava sve ponuđene artikle iz odabranog supermarketa, dok korisnik ima mogućnost unijeti ime artikla čime bi skratio vrijeme pretrage. Za svaki artikal je ispisana cijena i količina.
## Kreiranje spiska
Korisnik unosi lokaciju u čijem okruženju želi pretražiti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koji sadrže traženo ime, pa korisnik bira artikal i količinu i dodaje na svoj spisak. Nakon što je spisak završen korisnik dobiva listu preporučenih supermarketa u okolini tražene lokacije sortirani po ukupnoj vrijednosti računa počevši od najmanje. Ukoliko ne postoji supermarket koji zadovoljava korisnikov spisak, izlistavaju se supermarketi koji približno zadovoljavaju spisak.
## Registracija uposlenika supermarketa
Korisnik unosi svoje lične podatke, kontakt informacije i informacije o pripadajućem supermarketu, zahtjev za potvrdu uposlenika se šalje menadžeru pripadajućeg supermarketa. Ukoliko je zahtjev odobren, šalje se zahtjev za registraciju administratoru. Ukoliko je zahtjev odobren, korisnik dobiva privilegije uposlenika supermarketa.
## Registracija menadžera supermarketa
Korisnik unosi svoje lične podatke, kontakt informacije i informacije o pripadajućem supermarketu, zahtjev za registraciju se šalje administratoru. Ukoliko je zahtjev odobren, korisnik dobiva privilegije menadžera supermarketa.
## Dodavanje artikla u katalog
Uposlenik supermarketa upisuje podatke o artiklu i mora odabrati pripadajuči artikal iz baze podataka sistema, ukoliko ne postoji traženi artikal šalje zahtjev za dodavanje artikla na spisak u bazi podataka.
## Odobravanje zahtjeva
Uposlenik supermarketa opisuje artikal koji želi dodati u svoj katalog, zahtjev se šalje menadžeru tog supermarketa. Menadžer prima zahtjev i odluči da li da će prihvatiti ili odbiti zahtjev, nakon čega šalje zahtjev administratoru za unos artikla. Administrator prima zahtjev i unosi artikal u listu artikala, nakon čega se šalje obavijest uposleniku supermarketa o unosu artikla i odluci menadžera. Ukoliko je zahtjev odobren, administrator je dodao artikal u bazu podataka, a korisnik može ponovno pokušati dodati artikal u katalog supermarketa.

# Funkcionalnosti
- Mogućnost registracije na aplikaciju sa različitim ulogama
- Mogućnost prijave na aplikaciju sa različitim ulogama
- Mogućnost deaktiviranja korisničkog naloga
- CRUD mogućnost za svaku ulogu
- Mogućnost pretrage po imenu artikla
- Mogućnost pretrage kataloga supermarketa
- Kreiranje vlastitog spiska za kupovinu
- Mogućnost dodavanja novih supermarketa kao menadžer
- Slanje obavještenja o akcijskim cijenama
- Dodavanje i brisanje artikla u/iz katalog/a
- Ažuriranje cijene/količine artikla kao uposlenik supermarketa
- Mogućnost printanja spiska za kupovinu
- Like mogućnost za svaki supermarket
- Prikaz broja like-ova kataloga supermarketa
- Pretraga supermarketa putem GPS uređaja


# Akteri
1. Klijent - Osoba koja koristi aplikaciju radi informacija oko supermarketa u svojoj okolini, kao i artikala u njihovom katalogu. Ima mogućnost kreiranja vlastitog spiska kupovine pomoću kojeg ga aplikacija obavještava o najpovoljnijim kupovnim mjestima.

2. Uposlenik supermarketa - Osoba koja radi za supermarket i upravlja katalogom i artiklima supermarketa.

3. Menadžer supermarketa - Osoba koja radi za (određeni) supermarket i koja dodaje novootvorene supermarkete i njihovu lokaciju na listu već postojećih supermarketa. Također uz administratora odobrava registraciju novih radnika za korištenje aplikacije.

4. Administrator - Osoba koja upravlja bazom podataka artikala, dodaje ili uklanja artikle. Također, obrađuje zahtjeve za dodavanje novih artikala u bazu podataka.
