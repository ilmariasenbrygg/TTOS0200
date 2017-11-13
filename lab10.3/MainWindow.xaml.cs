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

namespace lab10._3
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

        double Pinta;
        double Lpinta;
        double Kpiiri;
        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            Pinta = double.Parse(Leveys.Text) * double.Parse(Korkeus.Text);
            Lpinta = (double.Parse(Leveys.Text)-(2*double.Parse(Karmipuu.Text))) * (double.Parse(Korkeus.Text)-(2 * double.Parse(Karmipuu.Text)));
            Kpiiri = (2 * double.Parse(Leveys.Text)) + (2 * double.Parse(Korkeus.Text));
            pintaala.Text = Pinta.ToString();
            lasipintaala.Text = Lpinta.ToString();
            karminpiiri.Text = Kpiiri.ToString();

            //Muodon vaihtuvuus

            Ulompi.Height = (double.Parse(Korkeus.Text) / 3000) * 260;
            Ulompi.Width = (double.Parse(Leveys.Text) / 3000) * 260;

            Sisempi.Height = ((double.Parse(Korkeus.Text)- (2 * (double.Parse(Karmipuu.Text)+55))) / 3000) * 260;
            Sisempi.Width = ((double.Parse(Leveys.Text) - (2 * (double.Parse(Karmipuu.Text)+55))) / 3000) * 260;
        }
        //  height 260/245  
        //  width 260/245
        private void Leveys_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Korkeus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Karmipuu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
