using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace e_market
{
    
    public sealed partial class RegistracijaKlijenta : Page
    {
        public RegistracijaKlijenta()
        {
            this.InitializeComponent();
            for(int i = 0; i < Prijava.kontejner.Gradovi.Count; i++)
            {
                gradComboBox.Items.Add(Prijava.kontejner.Gradovi[i].getNaziv());
            }
        }

        async void messageDialog(String s)
        {
            var dialog = new MessageDialog(s);
            await dialog.ShowAsync();
        }

        private void PotvrdiButtonClick(object sender, RoutedEventArgs e)
        {
            String ime = imeTextBox.Text;
            String prezime = prezimeTextBox.Text;
            String korisnickoIme = korisnickoImeTextBox.Text;
            String lozinka = lozinkaTextBox.Text;
            String email = emailTextBox.Text;
            String adresa = adresaStanovanjaTextBox.Text;

            if (imeTextBox.Text == string.Empty || prezimeTextBox.Text == string.Empty || korisnickoImeTextBox.Text == string.Empty || lozinkaTextBox.Text == string.Empty || emailTextBox.Text == string.Empty || adresaStanovanjaTextBox.Text == string.Empty ||
                potvrdiLozinkuTextBox.Text == string.Empty || potvrdiLozinkuTextBox.Text != lozinkaTextBox.Text || !emailTextBox.Text.Contains("@") )
            {
                messageDialog("Greška u unosu podataka!");
            }
            else
            {
                Prijava.kontejner.dodajKorisnika(new Klijent(ime, prezime, email, adresa, new Grad(), new Opcina(), new Naselje(), korisnickoIme, lozinka));

                messageDialog("Uspješna registracija!");
                this.Frame.Navigate(typeof(Prijava));

            }
        }

        private void NazadButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void gradComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for(int i = 0; i < Prijava.kontejner.Gradovi[gradComboBox.SelectedIndex].getOpcine().Count; i++)
            {
                opcinaComboBox.Items.Add(Prijava.kontejner.Gradovi[i].getOpcine()[i].getNaziv());
            }
        }
    }
}
