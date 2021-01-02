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
        public List<Operacion> ObtenerOperaciones(int CVU_cuenta)
        {
            List<Operacion> opc = new List<Operacion>();
            opc = dataAccess.ObtenerOperaciones(CVU_cuenta);
            return opc;
        }

        [HttpGet]
        // GET: api/Usuario/5
        [ActionName("RealizarTransferencia")]
        public bool RealizarTransferencia(int cuentaOrigen, double balanceOrigen, int cuentaDestino, double montoTransferencia, double totalGiro)
        {
            bool resultado = false;
            Operacion opc = new Operacion();
            opc.CVU_cuenta_destino = cuentaDestino;
            opc.CVU_cuenta_Origen = cuentaOrigen;
            opc.CVU_cuenta = cuentaOrigen;
            opc.verificacion_banco = true;
            opc.descripcion = "Transferencia pesos";
            opc.fecha_ocurrencia = DateTime.Now;
            opc.monto_original = montoTransferencia;
            opc.monto = montoTransferencia;
            opc.id_tipo_operacion = 1;
            opc.verificacion_origen_destino = true;
            opc.id_moneda = 1;
            resultado = dataAccess.NuevaOperacion(opc, balanceOrigen, totalGiro);
            return resultado;
        }
        

        [HttpPost]
        [ActionName("NuevaOperacion")]
        public bool NuevaOperacion(Operacion operacionN)
        {
            bool resultado = false;

            //resultado = dataAccess.NuevaOperacion(operacionN);
            return resultado;
        }

    }
}
