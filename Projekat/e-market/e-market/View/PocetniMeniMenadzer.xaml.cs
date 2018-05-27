using System;
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
    public sealed partial class PocetniMeniMenadzer : Page
    {
        public PocetniMeniMenadzer()
        {
            this.InitializeComponent();
        }

        private void ZahtjeviButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zahtjevi));
        }

        private void PosaljiObavjestenjeButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PosaljiObavjestenje));
        }

        private void DodajSupermarketButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodajSupermarket));
        }

        private void NalogButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IzmjenaLicnihPodataka));
        }

        private void odjavaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }


    }
}
