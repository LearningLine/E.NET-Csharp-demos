using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ConnectToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                ConfigurationManager.AppSettings["moviesServer"];
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * from movie";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["id"] + " " + reader["name"]);
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
