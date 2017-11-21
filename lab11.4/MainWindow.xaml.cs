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

namespace lab11._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Ykkönen.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Kakkonen.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Kolmonen.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Nelonen.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Vitonen.Content;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Kutonen.Content;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Seiska.Content;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Kasi.Content;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Ysi.Content;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Piste.Content;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if(LämpNap.IsChecked == true)
            {
                if(float.Parse(Syöte.Text) < 120 && float.Parse(Syöte.Text) > 0)
                {
                    Lämp.Text = Syöte.Text;
                }
                else
                {
                    Lämp.Text = "Syötä 0-100";
                }
            }
            if (KosteusNap.IsChecked == true)
            {
                if (float.Parse(Syöte.Text) < 100 && float.Parse(Syöte.Text) > 0)
                {
                    Kosteus.Text = Syöte.Text;
                }
                else
                {
                    Kosteus.Text = "Syötä 0-120";
                }
            }
            
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Syöte.Text = Syöte.Text.Substring(0, Syöte.Text.Length - 1);
        }

        private void Nolla_Click(object sender, RoutedEventArgs e)
        {
            Syöte.Text += Nolla.Content;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void KosteusNap_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
