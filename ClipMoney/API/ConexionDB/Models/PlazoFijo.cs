using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class PlazoFijo
    {
        /// <summary>
        /// Es el id del Plazo Fijo
        /// </summary>
        public int id_plazo_fijo { get; set; }
        /// <summary>
        /// Es el nombre del Plazo Fijo
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// Es la descripcion del Plazo Fijo
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es el monto ingresado en el Plazo Fijo
        /// </summary>
        public double monto_ingresado { get; set; }
        /// <summary>
        /// Es el monto de salida del Plazo Fijo
        /// </summary>
        public double monto_salida { get; set; }
        /// <summary>
        /// Es la fecha de creacion del Plazo Fijo
        /// </summary>
        public DateTime fecha_creacion { get; set; }
        /// <summary>
        /// Es la fecha de finalizacion del Plazo Fijo
        /// </summary>
        public DateTime fecha_finalizacion { get; set; }
        /// <summary>
        /// Es el objeto Cuenta del Plazo Fijo
        /// </summary>
        public Cuenta cuenta { get; set; }
        /// <summary>
        /// Es el CVU de la Cuenta en Plazo Fijo
        /// </summary>
        public int CVU_cuenta { get; set; }
    }
}
