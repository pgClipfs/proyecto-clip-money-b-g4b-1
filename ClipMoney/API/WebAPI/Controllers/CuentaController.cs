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
    public class CuentaController : ApiController
    {
        ADOCuenta dataAccess = new ADOCuenta();

        [HttpGet]
        // GET: api/Usuario/5
        [ActionName("ObtenerCuenta")]
        public Cuenta ObtenerCuenta(string usuario)
        {
            Cuenta cta = new Cuenta();
            cta = dataAccess.ObtenerCuenta(usuario);
            return cta;
        }

        [HttpPost]
        [ActionName("NuevaCuenta")]
        public bool NuevaCuenta(Cuenta cuentaN)
        {
            bool resultado = false;

            resultado = dataAccess.NuevaCuenta(cuentaN);
            return resultado;
        }
      
    }
}
