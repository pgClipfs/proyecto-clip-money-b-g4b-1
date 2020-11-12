using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Barrio
    {
       /// <summary>
       /// Es el id de barrio
       /// </summary>
        public int id_barrio { get; set; }
        /// <summary>
        /// Es el nombre de barrio
        /// </summary>
        public string barrio { get; set; }
        /// <summary>
        /// Es el objeto Localidad de Barrio
        /// </summary>
        public Localidad localidad { get; set; }
    }
}
