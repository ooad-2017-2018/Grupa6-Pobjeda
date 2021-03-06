﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class IzmjenaLicnihPodatakaAdministrator : Page
    {
        public IzmjenaLicnihPodatakaAdministrator()
        {
            this.InitializeComponent();
            imeBox.Text = Prijava.kontejner.Administratori[0].getIme();
            prezimeBox.Text = Prijava.kontejner.Administratori[0].getPrezime();
            korisnickoImeBox.Text = Prijava.kontejner.Administratori[0].getKorisnickoIme();

        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetniMeniAdministrator));
        }

        private void potvrdi_Click(object sender, RoutedEventArgs e)
        {
            Prijava.kontejner.Administratori[0].setIme(imeBox.Text);
            Prijava.kontejner.Administratori[0].setPrezime(prezimeBox.Text);
            Prijava.kontejner.Administratori[0].setKorisnickoIme(korisnickoImeBox.Text);
            Prijava.kontejner.Administratori[0].setLozinka(lozinkaBox.Password);
        }
    }
}
