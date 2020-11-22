using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class CuentaTipo
    {
        /// <summary>
        /// Es el id de Cuenta Tipo
        /// </summary>
        public int id_tipo_cuenta { get; set; }
        /// <summary>
        /// Es el nombre de Cuenta Tipo
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// Es la descripcion de Cuenta Tipo
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es el estado de Cuenta Tipo
        /// </summary>
        public bool estado { get; set; }
        /// <summary>
        /// Es el objeto Moneda de Cuenta Tipo
        /// </summary>
        public Moneda moneda { get; set; }
        /// <summary>
        /// Es el id de la moneda de Cuenta Tipo
        /// </summary>
        public int id_moneda { get; set; }

    }
}
