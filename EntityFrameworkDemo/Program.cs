using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MoviesEntities())
            {
                foreach (var studio in context.Studios)
                {
                    studio.Name = studio.Name.Trim();
                }
                context.SaveChanges();
            }
            using (var context = new MoviesEntities())
            {
                context.Database.Log = s => Debug.WriteLine(s);
                var studio = context.Studios.Where(s => s.Name == "Disney").First();
                Console.WriteLine("Movies for studio: " + studio.Name);
                var movies = context.Movies;
                var studioMovies = movies.Where(m => m.StudioId == studio.Id);
                foreach (var movie in studioMovies)
                {
                    Console.WriteLine(movie.Name);
                }
                Console.WriteLine("---");
                var studioAndMovies = from s in context.Studios
                    join m in context.Movies on
                        s.Id equals m.StudioId
                    select
                        new
                        {
                            Name = m.Name,
                            StudioName = s.Name
                        };
                foreach (var item in studioAndMovies)
                {
                    var s = item.StudioName.Trim() + " => " + item.Name;
                    Console.WriteLine(s);
                }
            }
            Console.Read();
        }
    }

}

namespace EntityFrameworkDemo
{
    public partial class Movie
    {
        public string PrettyName
        {
            get { return this.Name + this.Name; }
        }
    }
}

