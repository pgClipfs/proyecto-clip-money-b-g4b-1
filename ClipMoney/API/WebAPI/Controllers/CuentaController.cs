using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CuentaController : ApiController
    {
        // GET: api/Cuenta
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/Cuenta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cuenta
        public void Post([FromBody]string value)
        {
        }

 
    }
}
