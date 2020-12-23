using ConexionDB.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ConexionDB.ADOModels;

namespace WebAPI.Controllers
{
    public class CuentaAmigaController : ApiController
    {
        ADOCuentaAmiga dataAccess = new ADOCuentaAmiga();


        [HttpGet]
        // GET: api/DTOCuentaAmiga/5
        [ActionName("ObtenerListadoCuentasAmigas")]
        public List<DTOCuentaAmiga> ObtenerListadoCuentasAmigas(int id_usuario)
        {
            List<DTOCuentaAmiga> dtoCA = new List<DTOCuentaAmiga>();
            dtoCA = dataAccess.ObtenerCuentasAmigas(id_usuario);
            return dtoCA;
        }



    }
}
