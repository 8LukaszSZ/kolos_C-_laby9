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
using Microsoft.Data.SqlClient;

namespace lab8
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

        private void btnWczytaj_Click(object sender, RoutedEventArgs e)
        {
            using (var połączenie = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sklep;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                SqlCommand polecenie = new SqlCommand("SELECT * FROM Towary", połączenie);
                SqlCommand polecenieSrednia = new SqlCommand()
                połączenie.Open();
                SqlDataReader czytnik = polecenie.ExecuteReader();
                while(czytnik.Read()) 
                {
                    listDane.Items.Add($"{czytnik["Nazwa"]}, {czytnik["Cena"]:F2} zł, {czytnik["Ilość"]}");
                }

                czytnik.Close();
                połączenie.Close();
            }
        }
    }
}