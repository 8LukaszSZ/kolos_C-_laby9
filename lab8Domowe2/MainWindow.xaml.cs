using lab8Domowe2.Models;
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

namespace lab8Domowe2
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

        private void btnWyswietl_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbUczelnia();
            var uczniowie = db.Uczniowie.ToList();
            listDane.ItemsSource = uczniowie;

            if (uczniowie.Count > 0)
            {
                double? sumaOcen = 0;

                foreach (var uczen in uczniowie)
                {
                    sumaOcen += uczen.Ocena;
                }

                double? sredniaOcen = sumaOcen / uczniowie.Count;
                lblŚrednia.Content = $"Średnia: {sredniaOcen:F2}";
            }

        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbUczelnia();
            Uczen u = new Uczen()
            {
                Imię = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                Wiek = Convert.ToByte(txtWiek.Text),
                Ocena = Convert.ToDouble(txtOcena.Text),
            };
            db.Uczniowie.Add(u);
            db.SaveChanges();
            MessageBox.Show("Dodano pomyślnie!!");
        }
    }
}
