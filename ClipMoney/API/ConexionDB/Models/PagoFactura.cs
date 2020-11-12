using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class PagoFactura
    {
        /// <summary>
        /// Es el identificador de Pago Factura
        /// </summary>
        public int numero_factura { get; set; }
        /// <summary>
        /// Es el objeto Servicio de Pago Factura
        /// </summary>
        public Servicio servicio { get; set; }
        /// <summary>
        /// Es el estado de Pago Factura
        /// </summary>
        public bool estado { get; set; }
        /// <summary>
        /// Es la fecha de la factura de Pago Factura
        /// </summary>
        public DateTime fecha_factura { get; set; }
        /// <summary>
        /// Es el monto de Pago Factura
        /// </summary>
        public double monto { get; set; }
        /// <summary>
        /// Es el objeto Cuenta asociado a Pago Factura
        /// </summary>
        public Cuenta cuenta { get; set; }
    }
}
