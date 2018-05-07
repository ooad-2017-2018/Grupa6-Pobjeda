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

namespace e_market.View
{
    
    public sealed partial class RegistracijaKlijenta : Page
    {
        public RegistracijaKlijenta()
        {
            this.InitializeComponent();
        }

        private void PotvrdiButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void NazadButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }
    }
}
