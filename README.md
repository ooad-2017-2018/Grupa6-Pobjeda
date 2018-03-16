

# **E-Market**
![](https://photos-5.dropbox.com/t/2/AADVjCSykO1xyW6b_19QI7aeZQxN3RG9lmKvuup6v4FNNw/12/590805218/png/32x32/1/_/1/2/rsz_11online-grocery-shopping-pc.png/EMSkmOEEGCIgAigC/sr6mzCdYW7F0EXcBeX8nf4eysrNWGuCgPeAz4cF4Usw?preserve_transparency=1&size=1280x960&size_mode=3)

## Članovi tima:

1. Edo Škaljo
2. Amar Lučkin
3. Kenan Saračević

## Opis teme:
E-Market je aplikacija koja korisniku omogućava da pregleda katalog artikala svakog supermarketa u svojoj okolini.
Svrha aplikacije je promocija artikala supermarketa putem online kataloga.
Ova aplikacija korisniku omogućava da pregleda cijene svih artikala u svim supermarketima, kao i da sastavi svoju vlastitu shopping listu pomoću koje će mu sistem predložiti najpovoljniju lokaciju za kupovinu.
Aplikacija pruža vlasniku supermarketa novi način promocije promotivnih cijena kao i jednostavnije pružanje informacija kupcima o svojim artiklima.

# Procesi
## Registracija klijenta
Korisnik unosi svoje lične podatke među kojima se nalazi i mjesto stanovanja koje omogućava sistemu da pronađe supermarkete koji su u okruženju mjesta stanovanja korisnika.
## Pretraga po artiklu
Korisnik unosi lokaciju u čijem okruženju želi pretražiti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koje sadrže traženi naziv iz svakog supermarketa. Proizvodi su sortirani po cijeni počevši od najmanje.
## Pretraga po supermarketu (katalog)
Korisnik unosi lokaciju u čijem okruženju želi pretražiti proizvod, zatim bira supermarket čiji katalog želi da pretražuje. Sistem izlistava sve ponuđene artikle iz odabranog supermarketa, dok korisnik ima mogućnost unijeti ime artikla čime bi skratio vrijeme pretrage. Za svaki artikal je ispisana cijena i količina.
## Sastavljanje spiska
Korisnik unosi lokaciju u čijem okruženju želi pretražiti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koji sadrže traženo ime, pa korisnik bira artikal i količinu i dodaje na svoj spisak. Nakon što je spisak završen korisnik dobiva listu preporučenih supermarketa u okolini tražene lokacije sortirani po ukupnoj vrijednosti računa počevši od najmanje. Ukoliko ne postoji supermarket koji zadovoljava korisnikov spisak, izlistavaju se supermarketi koji približno zadovoljavaju spisak.
## Registracija uposlenika supermarketa
Korisnik unosi svoje lične podatke, kontakt informacije i informacije o pripadajućem supermarketu.
## Dodavanje artikla u katalog
Uposlenik supermarketa upisuje podatke o artiklu i mora odabrati pripadajuči artikal iz baze podataka sistema, ukoliko ne postoji traženi artikal šalje zahtjev za dodavanje artikla na spisak u bazi podataka.
## Slanje zahtjeva
Uposlenik supermarketa opisuje artikal koji želi dodati u svoj katalog, zahtjev se šalje administratoru sistema. Administratog prima zahtjev i odluči da li da prihvati ili odbije zahtjev, nakon čega se šalje obavijest uposleniku supermarketa o odluci administratora. Ukoliko je zahtjev odobren, administrator je dodao artikal u bazu podataka, a korisnik može ponovno pokušati dodati artikal u katalog supermarketa.

# Funkcionalnosti
- Mogućnost registracije na aplikaciju
- Mogućnost prijave na aplikaciju
- Mogućnost brisanja korisničkog naloga
- CRUD mogućnost za svaku ulogu
- Mogućnost pretrage po imenu artikla
- Mogućnost pretrage kataloga supermarketa
- Sastavljanje vlastitog spiska za kupovinu
- Mogućnost dodavanja novih supermarketa
- Mogućnost biranja između različitih prijevoznih sredstava
- Automatsko ažuriranje količine proizvoda u supermarketima 
- Transparetna pristupnost bazi podataka supermarketa
- Slanje obavještenja o akcijskim cijenama
- Dodavanje novog artikla u katalog
- Brisanje artikla iz kataloga
- Promjena cijene artikla
- Promjena količine artikla
- Prikaz broja pregleda kataloga supermarketa
- Pretraga supermarketa putem GPS uređaja
(ovdje treba još dodati funkcionalnosti, pročitati projektni zadatak 2)

# Akteri
1. Klijent - Osoba koja koristi aplikaciju radi informacija oko supermarketa u svojoj okolini, kao i artikala u njihovom katalogu. Ima mogućnost kreiranja vlastitog spiska kupovine pomoću kojeg ga aplikacija obavještava o najpovoljnijim kupovnim mjestima.

2. Uposlenik supermarketa - Osoba koja radi za supermarket i upravlja katalogom i artiklima supermarketa.

3. Menadžer supermarketa - Osoba koja radi za (određeni) supermarket i koja dodaje novootvorene supermarkete i njihovu lokaciju na listu već postojećih supermarketa.

4. Administrator - Osoba koja upravlja bazom podataka artikala, dodaje ili uklanja artikle. Također, obrađuje zahtjeve za dodavanje novih artikala u bazu podataka.
