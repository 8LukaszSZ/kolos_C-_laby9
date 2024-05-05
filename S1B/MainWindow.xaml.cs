using S1B.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S1B
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
            //foreach (var student in db.Studenci) 
            // {
            //    listDane.Items.Add(student);
            //}
            listDane.ItemsSource = db.Studenci.ToList();

            
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbUczelnia();
            Student s = new Student()
            {
                Imię = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                Wiek = Convert.ToByte(txtWiek.Text),
                Ocena = Convert.ToDouble(txtOcena.Text),
            };
            db.Studenci.Add(s);
            db.SaveChanges();
            MessageBox.Show("Dodano pomyślnie!!");
        }
    }
}