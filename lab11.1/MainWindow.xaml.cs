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

namespace lab11._1
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
            if ((bool)Voi.IsChecked)
            {
                Ostokset.Text +=  Voi.Name + ", ";
            }
            if ((bool)Kahvi.IsChecked)
            {
                Ostokset.Text += Kahvi.Name + ", ";
            }
            if ((bool)Banaani.IsChecked)
            {
                Ostokset.Text += Banaani.Name + ", ";
            }
            if ((bool)Maito.IsChecked)
            {
                Ostokset.Text += Maito.Name + ", ";
            }
            if ((bool)Kalja.IsChecked)
            {
                Ostokset.Text += Kalja.Name + ", ";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
