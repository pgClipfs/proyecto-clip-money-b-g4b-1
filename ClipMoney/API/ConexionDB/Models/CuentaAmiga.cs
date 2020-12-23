using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
   public class CuentaAmiga
    {
        /// <summary>
        /// El id de la cuenta amiga
        /// </summary>
        public int id_cuenta_amiga { get; set; }
        /// <summary>
        /// El id usuario de la cuenta amiga
        /// </summary>
        public int id_usuario { get; set; }
        /// <summary>
        /// El CVU de la cuenta amiga
        /// </summary>
        public int CVU { get; set; }
        /// <summary>
        /// La fecha de la última transacción de la cuenta amiga
        /// </summary>
        public DateTime fecha_ultima_transaccion { get; set; }
    }
}
