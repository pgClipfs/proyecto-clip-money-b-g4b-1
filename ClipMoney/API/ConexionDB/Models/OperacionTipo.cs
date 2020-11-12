using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class OperacionTipo
    {
        /// <summary>
        /// Es el id de Operacion Tipo
        /// </summary>
        public int id_tipo_operacion { get; set; }
        /// <summary>
        /// Es la descripcion de Operacion Tipo
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es el estado de Operacion Tipo
        /// </summary>
        public bool estado { get; set; }
        /// <summary>
        /// Es el nombre de Operacion Tipo
        /// </summary>
        public string nombre { get; set; }
    }
}
