using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Acme.Slots.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get all the values that are currently stored in the system
        /// </summary>
        /// <returns>List of values</returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get the value by id
        /// </summary>
        /// <param name="id">Id of the value to retreive</param>
        /// <returns>A value</returns>
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Post it!
        /// </summary>
        /// <param name="value">Value to post</param>
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Put a value into the system
        /// </summary>
        /// <param name="id">An Id of the value</param>
        /// <param name="value">Actual value</param>
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Deletes a value from the system
        /// </summary>
        /// <param name="id">An Id of the value</param>
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
