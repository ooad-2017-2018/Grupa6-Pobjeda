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
    public sealed partial class Prijava : Page
    {
        private static Kontejner _kontejner = new Kontejner();

        public static Kontejner kontejner { get => _kontejner; set => _kontejner = value; }

        async void messageDialog(String s)
        {
            var dialog = new MessageDialog(s);
            await dialog.ShowAsync();
        }

        public Prijava()
        {
            this.InitializeComponent();
        }

        private void klijentButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaKlijenta));
        }

        private void menadzerButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaMenadzera));
        }

        private void spUposlenikButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaUposlenikaSupermarketa));
        }

        private void loginButtonClick(object sender, RoutedEventArgs e)
        {
            String username = usernameTextBox.Text;
            String lozinka = lozinkaTextBox.Password;

            int i = Prijava.kontejner.dajUsera(username, lozinka);
            if (i == 0) {
                this.Frame.Navigate(typeof(PocetniMeniKlijent));
            }
            else if(i == 1)
            {
                this.Frame.Navigate(typeof(PocetniMeniMenadzer));
            }
            else if(i == 2)
            {
                this.Frame.Navigate(typeof(PocetniMeniUposlenik));
            }
            else if(i == 3)
            {
                if(kontejner.Administratori[0].Deaktiviran == true)
                {
                    messageDialog("Ovaj akaunt je deaktiviran, obratite se glavnom administratoru!");
                }
                else
                    this.Frame.Navigate(typeof(PocetniMeniAdministrator));
            }
            else
            {
                messageDialog("Ne postoji korisnik sa tim podacima!");
            }
        }
    }
}
