﻿using System;
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

namespace lab10._2
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
        
        double number;
        double number2;
        private void ostomäärä_TextChanged(object sender, TextChangedEventArgs e)
        {
            double luku;
            if (double.TryParse(ostomäärä.Text, out luku))
            {
                if (Valuutanvalinta.SelectedItem == USD)
                {
                    number = double.Parse(ostomäärä.Text);
                    number2 = number * 0.8997;
                    maksumäärä.Text = number2.ToString("0.00");
                }
                else if (Valuutanvalinta.SelectedItem == EUR)
                {
                    number = double.Parse(ostomäärä.Text);
                    number2 = number / 0.8997;
                    maksumäärä.Text = number2.ToString("0.00");
                }
            }
            else
            {
                maksumäärä.Text = "Ei ole luku";
            }
        }

      

        private void Valuutanvalinta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void USD_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void maksumäärä_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
