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

namespace bike_factory
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dpEingabe_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gridEingabe.Visibility = Visibility.Visible;
            gridKapazitätsplan.Visibility = Visibility.Hidden;
            gridEigenfertigung.Visibility = Visibility.Hidden;
            gridBestellungen.Visibility = Visibility.Hidden;
        }

        private void dpKapazitätsplanung_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gridEingabe.Visibility = Visibility.Hidden;
            gridKapazitätsplan.Visibility = Visibility.Visible;
            gridEigenfertigung.Visibility = Visibility.Hidden;
            gridBestellungen.Visibility = Visibility.Hidden;
        }

        private void dpEigenfertigung_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gridEingabe.Visibility = Visibility.Hidden;
            gridKapazitätsplan.Visibility = Visibility.Hidden;
            gridEigenfertigung.Visibility = Visibility.Visible;
            gridBestellungen.Visibility = Visibility.Hidden;
        }

        private void dpBestellungen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gridEingabe.Visibility = Visibility.Hidden;
            gridKapazitätsplan.Visibility = Visibility.Hidden;
            gridEigenfertigung.Visibility = Visibility.Hidden;
            gridBestellungen.Visibility = Visibility.Visible;
        }
    }
}
