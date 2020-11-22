using ConexionDB.ADOModels;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class BarrioController : ApiController
    {
        ADOBarrio dataAccess = new ADOBarrio();



        [HttpGet]
        // GET: api/Usuario/5
        [ActionName("ObtenerBarrios")]
        public List<Barrio> ObtenerBarrios()
        {
            List<Barrio> barrios = new List<Barrio>();
            barrios = dataAccess.ObtenerBarrios();
            return barrios;
        }

    }
}
