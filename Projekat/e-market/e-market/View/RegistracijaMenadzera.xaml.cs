using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace e_market
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaMenadzera : Page
    {
        public RegistracijaMenadzera()
        {
            this.InitializeComponent();
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
                potvrdiLozinkuTextBox.Text == string.Empty || potvrdiLozinkuTextBox.Text != lozinkaTextBox.Text || !emailTextBox.Text.Contains("@"))
            {
                messageDialog("Greška u unosu podataka!");
            }
            else
            {
                Prijava.kontejner.dodajMenadžera(new Menadzer(ime, prezime, email, adresa, new Grad(), new Opcina(), new Naselje(), korisnickoIme, lozinka, new Lanac(), null, null));
                messageDialog("Uspješna registracija!");
                this.Frame.Navigate(typeof(Prijava));

            }
        }

        private void nazadButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }
    }
}
