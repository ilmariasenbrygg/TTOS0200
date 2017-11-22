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

namespace lab11._3
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
            try
            {

            


            int osumat;
            int nro;
            string rivi;
            Random rnd = new Random();
            if (Combo.SelectedItem == Lotto)
            {

                for (int i = 0; i < int.Parse(Määrä.Text); i++)
                {
                    bool[] numerot = new bool[40];
                    osumat = 0;
                    do
                    {
                        nro = rnd.Next(1, 40);
                        if (numerot[nro] == false)
                        {
                            numerot[nro] = true;
                            osumat++;
                        }
                    } while (osumat < 7);

                    rivi = String.Format("Rivi {0}: ", i);
                    for (int j = 0; j < 40; j++)
                    {
                        if (numerot[j])
                        {
                            rivi += (j + 1).ToString() + " ";
                        }
                    }
                    Rivit.Text += rivi + "\n";
                }
            }
            else if (Combo.SelectedItem == Viking)
            {
                for (int i = 0; i < int.Parse(Määrä.Text); i++)
                {
                    bool[] numerot = new bool[48];
                    osumat = 0;
                    do
                    {
                        nro = rnd.Next(1, 48);
                        if (numerot[nro] == false)
                        {
                            numerot[nro] = true;
                            osumat++;
                        }
                    } while (osumat < 6);

                    rivi = String.Format("Rivi {0}: ", i);
                    for (int j = 0; j < 48; j++)
                    {
                        if (numerot[j])
                        {
                            rivi += (j + 1).ToString() + " ";
                        }
                    }
                    Rivit.Text += rivi + "\n";
                }
            }
            else if (Combo.SelectedItem == Euro)
            {
                for (int i = 0; i < int.Parse(Määrä.Text); i++)
                {
                    bool[] numerot = new bool[50];
                    bool[] lisä = new bool[10];
                    osumat = 0;
                    int nro2;
                    do
                    {
                        nro = rnd.Next(1, 50);
                        if (numerot[nro] == false)
                        {
                            numerot[nro] = true;
                            osumat++;
                        }
                    } while (osumat < 5);
                    osumat = 0;
                    do
                    {
                        nro2 = rnd.Next(1, 10);
                        if (lisä[nro2] == false)
                        {
                            lisä[nro2] = true;
                            osumat++;
                        }
                    } while (osumat < 2);
                    string lisät = "";
                    for (int k = 0; k < 10; k++)
                    {
                        if (lisä[k])
                        {
                            lisät += k.ToString() + ",";
                        }
                    }
                    //string lisät = lisä[0].ToString() + lisä[1].ToString();
                    rivi = String.Format("Rivi {0}: ", i);
                    for (int j = 0; j < 50; j++)
                    {
                        if (numerot[j])
                        {
                            rivi += (j + 1).ToString() + " ";
                        }

                    }
                    rivi += "+" + lisät;
                    Rivit.Text += rivi + "\n";
                }
            }
        }
            catch (Exception ex)
            {

                Virhe.Text = ex.Message;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rivit.Text = "";
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
