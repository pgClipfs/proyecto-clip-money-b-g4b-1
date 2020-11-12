using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Operacion
    {
        /// <summary>
        /// Es el id de la Operacion
        /// </summary>
        public int id_operacion { get; set; }
        /// <summary>
        /// Es el objeto Cuenta asociada a la Operacion
        /// </summary>
        public Cuenta cuenta { get; set; }
        /// <summary>
        /// Es el objeto Cuenta (de destino) asociada a la Operacion
        /// </summary>
        public Cuenta cuentaDestino { get; set; }
        /// <summary>
        /// Es el objeto Cuenta (de origen) asociada a la Operacion
        /// </summary>
        public Cuenta cuentaOrigen { get; set; }
        /// <summary>
        /// Es la verificacion del Banco de la Operacion
        /// </summary>
        public bool verificacion_banco { get; set; }
        /// <summary>
        /// Es la descripcion de la Operacion
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es la fecha de la ocurrencia de la Operacion
        /// </summary>
        public DateTime fecha_ocurrencia { get; set; }
        /// <summary>
        /// Es el monto original de la Operacion
        /// </summary>
        public double monto_original { get; set; }
        /// <summary>
        /// Es el monto de la Operacion
        /// </summary>
        public double monto { get; set; }
        /// <summary>
        /// Es el objeto Operacion Tipo asociada a la Operacion
        /// </summary>
        public OperacionTipo operacionTipo { get; set; }
        /// <summary>
        /// Es la verificacion (origen/destino) de la Operacion
        /// </summary>
        public bool verificacion_origen_destino { get; set; }
        /// <summary>
        /// Es el objeto Moneda asociada a la Operacion
        /// </summary>
        public Moneda moneda { get; set; }
    }
}
