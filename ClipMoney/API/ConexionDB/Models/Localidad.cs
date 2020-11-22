using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Localidad
    {
        /// <summary>
        /// Es el id de localidad
        /// </summary>
        public int id_localidad { get; set; }
        /// <summary>
        /// Es el nombre de la localidad
        /// </summary>
        public string localidad { get; set; }
        /// <summary>
        /// Es el objeto provincia de localidad
        /// </summary>
        public Provincia provincia { get; set; }
        /// <summary>
        /// Es el id de la provincia de localidad
        /// </summary>
        public int id_provincia { get; set; }

    }
}
