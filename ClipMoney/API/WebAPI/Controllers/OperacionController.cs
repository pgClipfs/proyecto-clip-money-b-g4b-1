using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class OperacionController : ApiController
    {
        // GET: api/Operacion
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Operacion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Operacion
        public void Post([FromBody]string value)
        {
        }

    }
}
