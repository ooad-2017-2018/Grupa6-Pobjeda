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
    public sealed partial class IzmjenaLicnihPodataka : Page
    {
        public IzmjenaLicnihPodataka()
        {
            this.InitializeComponent();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (i == 0)
                this.Frame.Navigate(typeof(PocetniMeniKlijent));
            else if (i == 1)
                this.Frame.Navigate(typeof(PocetniMeniUposlenik));
            else
                this.Frame.Navigate(typeof(PocetniMeniMenadzer));
        }
    }
}
