using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using Microsoft.Win32;

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





        //CODE FÜR EINGABE
        //Input-File wird ausgewählt
        private void btnOpenInputFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog inputFileDialog = new OpenFileDialog();
            if (inputFileDialog.ShowDialog() == true)
               lblInputFileName.Content = inputFileDialog.FileName;
        }
        //CODE FÜR KAPA-PLANUNG

        //CODE FÜR BESTELLUNGEN

        //CODE FÜR EIGENFERTIGUNG

        //CODE FÜR DAS MENÜ
        //Wenn man auf einenn Menüpunkt Klickt, wird es sichtbar
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
