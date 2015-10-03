using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAjax.Controllers
{
    public class ArrayWrapper<T>
    {
        public T[]      Items{ get; set; }
    }
    public class MoviesController : ApiController
    {
        // GET api/values
         IEnumerable<Movie> GetImp()
        {
            yield return new Movie() { Name = "Mad max" };
            yield return new Movie() { Name = "Pride and prejudice" };
        }

        public ArrayWrapper<Movie> Get()
        {
            return new ArrayWrapper<Movie>() {Items = GetImp().ToArray()};
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Movie


    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
