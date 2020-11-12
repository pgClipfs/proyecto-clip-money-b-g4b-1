using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Servicio
    {
        /// <summary>
        /// Es el id de Servicio
        /// </summary>
        public int id_servicio { get; set; }
        /// <summary>
        /// Es el nombre de Servicio
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// Es la descripcion de Servicio
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es el objeto Servicio Tipo de Servicio
        /// </summary>
        public ServicioTipo servicioTipo { get; set; }

    }
}
