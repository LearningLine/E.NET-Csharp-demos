using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace MovieGui
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

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            string connectionString =
                           ConfigurationManager.AppSettings["moviesServer"];
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var movies = new List<Movie>();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * from movie";
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            movies.Add(new Movie {Name = (string) reader["name"], Id = (int) reader["id"]});
                            Console.WriteLine(reader["id"] + " " + reader["name"]);
                        }
                    }
                }
                DataContext = movies;

            }

        }
    }
}
