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
using Microsoft.Data.SqlClient;

namespace lab8domowe
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

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            using (var połączenie = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Studenci;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand polecenie = new SqlCommand("SELECT * FROM Studenci", połączenie);
                SqlCommand polecenieSrednia = new SqlCommand();
                połączenie.Open();
                SqlDataReader czytnik = polecenie.ExecuteReader();
                while (czytnik.Read())
                {
                    listDane.Items.Add($"{czytnik["Imie"]}, {czytnik["Nazwisko"]}, {czytnik["Wiek"]}");
                }

                czytnik.Close();
                połączenie.Close();
            }
        }
    }
}
