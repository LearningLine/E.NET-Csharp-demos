using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("");
            var movies = connection.Query<Movie>(new CommandDefinition("select * from movies"));
            foreach (var movie in movies)
            {
                
            }
        }
    }

    class Movie
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
