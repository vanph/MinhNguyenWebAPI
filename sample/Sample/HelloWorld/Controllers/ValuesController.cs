using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "pham hong van";
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

        [HttpGet]
        public List<Person> GetPersons()
        {
            var lst = new List<Person>
            {
                new Person {FirstName = "Van", LastName = "Pham"},
                new Person {FirstName = "Minh", LastName = "Nguyen"},
                new Person {FirstName = "Hai", LastName = "Nguyen"},
                new Person {FirstName = "Phu", LastName = "Do"},
                new Person {FirstName = "Ha", LastName = "Tran"},
            };
            
            return lst;
        }
    }
}
