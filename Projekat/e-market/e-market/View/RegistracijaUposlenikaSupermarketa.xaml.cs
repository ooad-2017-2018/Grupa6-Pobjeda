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
    public sealed partial class RegistracijaUposlenikaSupermarketa : Page
    {
        public RegistracijaUposlenikaSupermarketa()
        {
            this.InitializeComponent();


            for (int i = 0; i < Prijava.kontejner.LanciSupermarketa.Count; i++)
                superMarketBox.Items.Add(Prijava.kontejner.LanciSupermarketa[i].getNaziv());
            for (int i = 0; i < Prijava.kontejner.Gradovi.Count; i++)
            {
                gradComboBox.Items.Add(Prijava.kontejner.Gradovi[i].getNaziv());
                gradBox.Items.Add(Prijava.kontejner.Gradovi[i].getNaziv());
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
            String lozinka = lozinkaTextBox.Password;
            String email = emailTextBox.Text;
            String adresa = adresaStanovanjaTextBox.Text;

            if (imeTextBox.Text == string.Empty || prezimeTextBox.Text == string.Empty || korisnickoImeTextBox.Text == string.Empty || lozinkaTextBox.Password == string.Empty || emailTextBox.Text == string.Empty || adresaStanovanjaTextBox.Text == string.Empty ||
                potvrdiLozinkuTextBox.Password == string.Empty || potvrdiLozinkuTextBox.Password != lozinkaTextBox.Password || !emailTextBox.Text.Contains("@") ||  !(gradComboBox.SelectedIndex >= 0) ||
                !(opcinaComboBox.SelectedIndex >= 0) || !(naseljeComboBox.SelectedIndex >= 0) || !(superMarketBox.SelectedIndex >= 0) || !(gradBox.SelectedIndex >= 0) ||
                !(opcinaBox.SelectedIndex >= 0) || !(naseljeBox.SelectedIndex >= 0))
            {
                messageDialog("Greška u unosu podataka!");
            }
            else
            {
                Prijava.kontejner.dodajUposlenika(new Uposlenik(ime, prezime, email, adresa, new Grad(), new Opcina(), new Naselje(), korisnickoIme, lozinka, Prijava.kontejner.LanciSupermarketa[superMarketBox.SelectedIndex], null));
                messageDialog("Uspješna registracija!");
                this.Frame.Navigate(typeof(Prijava));

            }
        }

        private void nazadButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void gradComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < Prijava.kontejner.Gradovi[gradComboBox.SelectedIndex].getOpcine().Count; i++)
            {
                opcinaComboBox.Items.Add(Prijava.kontejner.Gradovi[gradComboBox.SelectedIndex].getOpcine()[i].getNaziv());
            }
        }

        private void gradBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < Prijava.kontejner.Gradovi[gradBox.SelectedIndex].getOpcine().Count; i++)
            {
                opcinaBox.Items.Add(Prijava.kontejner.Gradovi[gradBox.SelectedIndex].getOpcine()[i].getNaziv());
            }
        }


        private void opcinaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            naseljeComboBox.Items.Clear();
            for (int i = 0; i < Prijava.kontejner.Gradovi[gradComboBox.SelectedIndex].getOpcine()[opcinaComboBox.SelectedIndex].getNaselja().Count; i++)
            {
                naseljeComboBox.Items.Add(Prijava.kontejner.Gradovi[gradComboBox.SelectedIndex].getOpcine()[opcinaComboBox.SelectedIndex].getNaselja()[i].getNaziv());
            }
        }

        private void opcinaBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            naseljeBox.Items.Clear();
            for (int i = 0; i < Prijava.kontejner.Gradovi[gradBox.SelectedIndex].getOpcine()[opcinaBox.SelectedIndex].getNaselja().Count; i++)
            {
                naseljeBox.Items.Add(Prijava.kontejner.Gradovi[gradBox.SelectedIndex].getOpcine()[opcinaBox.SelectedIndex].getNaselja()[i].getNaziv());
            }
        }
    }
}
