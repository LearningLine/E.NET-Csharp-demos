using System.Collections.Generic;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
   public class MoviesController : ApiController
    {
        // GET api/values
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>
            {
                new Movie {Name = "Mad max"},
                new Movie {Name = "Black mass"}
            };
        }

        // GET api/values/5
        public Movie Get(int id)
        {
            return new Movie {Name = "Mad max"};
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}