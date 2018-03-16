# E-Market
1. Edo �kaljo
2. Amar Lu�kin
3. Kenan Sara�evi�

## Opis teme:
E-Market je aplikacija koja korisniku omogu�ava da pregleda katalog artikala svakog supermarketa u svojoj okolini.
Svrha aplikacije je promocija artikala supermarketa putem online kataloga.
Ova aplikacija korisniku omogu�ava da pregleda cijene svih artikala u svim supermarketima, kao i da sastavi svoju vlastitu shopping listu pomo�u koje �e mu sistem predlo�iti najpovoljniju lokaciju za kupovinu.
Aplikacija pru�a vlasniku supermarketa novi na�in promocije promotivnih cijena kao i jednostavnije pru�anje informacija kupcima o svojim artiklima.

# Procesi
## Registracija klijenta
Korisnik unosi svoje li�ne podatke me�u kojima se nalazi i mjesto stanovanja koje omogu�ava sistemu da prona�e supermarkete koji su u okru�enju mjesta stanovanja korisnika.
## Pretraga po artiklu
Korisnik unosi lokaciju u �ijem okru�enju �eli pretra�iti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koje sadr�e tra�eni naziv iz svakog supermarketa. Proizvodi su sortirani po cijenu po�ev�i od najmanje.
## Pretraga po supermarketu (katalog)
Korisnik unosi lokaciju u �ijem okru�enju �eli pretra�iti proizvod, zatim bira supermarket �iji katalog �eli da pretra�uje. Sistem izlistava sve ponu�ene artikle iz odabranog supermarketa, dok korisnik ima mogu�nost unijeti ime artikla �ime bi skratio vrijeme pretrage. Za svaki artikal je ispisana cijena i koli�ina.
## Sastavljanje spiska
Korisnik unosi lokaciju u �ijem okru�enju �eli pretra�iti proizvod, zatim unosi ime artikla. Sistem izlistava sve artikle koji sadr�e tra�eno ime, pa korisnik bira artikal i koli�inu i dodaje na svoj spisak. Nakon �to je spisak zavr�en korisnik dobiva listu preporu�enih supermarketa u okolini tra�ene lokacije sortirani po ukupnoj vrijednosti ra�una po�ev�i od najmanje. Ukoliko ne postoji supermarket koji zadovoljava korisnikov spisak, izlistavaju se supermarketi koji pribli�no zadovoljavaju spisak.
## Registracija uposlenika supermarketa
Korisnik unosi svoje li�ne podatke, kontakt informacije i informacije o pripadaju�em supermarketu.
## Dodavanje artikla u katalog
Uposlenik supermarketa upisuje podatke o artiklu i mora odabrati pripadaju�i artikal iz baze podataka sistema, ukoliko ne postoji tra�eni artikal �alje zahtjev za dodavanje artikla na spisak u bazi podataka.
## Slanje zahtjeva
Uposlenik supermarketa opisuje artikal koji �eli dodati u svoj katalog, zahtjev se �alje administratoru sistema. Administratog prima zahtjev i odlu�i da li da prihvati ili odbije zahtjev, nakon �ega se �alje obavijest uposleniku supermarketa o odluci administratora. Ukoliko je zahtjev odobren, administrator je dodao artikal u bazu podataka, a korisnik mo�e ponovno poku�ati dodati artikal u katalog supermarketa.

# Funkcionalnosti
- Mogu�nost prijave na aplikaciju
- CRUD mogu�nost za svaku ulogu
- Mogu�nost pretrage po imenu artikla
- Mogu�nost pretrage katalog supermarketa
- Sastavljanje vlastitog spiska za kupovinu
- Slanje obavje�tenja o akcijskim cijenama
- Dodavanje novog artikla u katalog
- Brisanje artikla iz kataloga
- Promjena cijene artikla
- Promjena koli�ine artikla
- Prikaz broja pregleda kataloga supermarketa
- Pretraga supermarketa putem GPS ure�aja
(ovdje treba jo� dodati funkcionalnosti, pro�itati projektni zadatak 2)

# Akteri
1. Klijent - Osoba koja koristi aplikaciju radi informacija oko supermarketa u svojoj okolini, kao i artikala u njihovom katalogu. Ima mogu�nost kreiranja vlastitog spiska kupovine pomo�u kojeg ga aplikacija obavje�tava o najpovoljnijim kupovnim mjestima.

2. Uposlenik supermarketa - Osoba koja radi za supermarket i upravlja katalogom i artiklima supermarketa.

3. Administrator - Osoba koja upravlja bazom podataka artikala, dodaje ili uklanja artikle. Tako�er, obra�uje zahtjeve za dodavanje novih artikala u bazu podataka.
