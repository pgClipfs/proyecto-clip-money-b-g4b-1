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
    public class OperacionController : ApiController
    {
        ADOOperacion dataAccess = new ADOOperacion();

        [HttpGet]
        // GET: api/Usuario/5
        [ActionName("ObtenerOperacion")]
        public Operacion ObtenerOperacion(int id_operacion, int CVU_cuenta)
        {
            Operacion opc = new Operacion();
            opc = dataAccess.ObtenerOperacion(id_operacion,CVU_cuenta);
            return opc;
        }

        [HttpGet]
        // GET: api/Usuario/5
        [ActionName("ObtenerOperaciones")]
        public Operacion ObtenerOperaciones(int CVU_cuenta)
        {
            Operacion opc = new Operacion();
            opc = dataAccess.ObtenerOperaciones(CVU_cuenta);
            return opc;
        }

        [HttpPost]
        [ActionName("NuevaOperacion")]
        public bool NuevaOperacion(Operacion operacionN)
        {
            bool resultado = false;

            resultado = dataAccess.NuevaOperacion(operacionN);
            return resultado;
        }

    }
}
