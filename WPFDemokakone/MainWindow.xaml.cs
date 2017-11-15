using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemokakone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot;
        private const string polku = @"D:\K1538\Visualstudio\TTOS0200\";
        public MainWindow()
        {
            //tänne koodi joka suoritetaan aina ikkunan avauksen yhteydessä
            InitializeComponent();
            NaytaKuva("autotalli.png");
            autot = Autotalli.HaeAutot();
            //Asetetaan comboboxiin kaikki eri automerkit
            //VE1: käsin koodaamalla
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            cmbAutot.ItemsSource = merkit;
            //VE2: parempi, kysytään LINQ datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            //Pyydetään auto BL kerrokselta
            
            dgAutot.ItemsSource = autot;
        }
        private void NaytaKuva(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                url = "puuttuu.png";
            }
            //vakiopoolku
            url = polku + url;

            BitmapImage pic = new BitmapImage();
            pic.BeginInit();
            pic.UriSource = new Uri(url);
            pic.EndInit();
            imgAuto.Stretch = Stretch.Fill;
            imgAuto.Source = pic;
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom olemme itse populoineet datagridin auto-olioilla, joten kukin datagridin jäsen/alki on auto olio
            object obj = dgAutot.SelectedItem;
            if( obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin pelkästäään audit
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //suodatetaan datagridiin näkyviin vain valittu automerkkiiiiiiii
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            NaytaKuva("autotalli.png");
        }
    }
}
