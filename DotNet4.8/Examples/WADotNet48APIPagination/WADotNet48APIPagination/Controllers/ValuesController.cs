using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WADotNet48APIPagination.Controllers
{
    public class ValuesController : ApiController
    {
        // GET API/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET API/values
        [Route("api/GetData")]
        public IEnumerable<string> GetData()
        {
            using(DefaultPaginationData data = new DefaultPaginationData())
            {
                return data.GetData();
            }

        }

        // GET API/values/5
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST API/values
        public void Post([FromBody] string value)
        {
        }

        // PUT API/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE API/values/5
        public void Delete(int id)
        {
        }
    }
}
