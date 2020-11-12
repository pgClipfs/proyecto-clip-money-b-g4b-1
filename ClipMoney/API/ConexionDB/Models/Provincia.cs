using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Provincia
    {
        /// <summary>
        /// Es el id de la provincia
        /// </summary>
        public int id_provincia { get; set; }
        /// <summary>
        /// Es el nombre de la provincia
        /// </summary>
        public string provincia { get; set; }
        /// <summary>
        /// Es el objeto Pais de la Provincia
        /// </summary>
        public Pais pais { get; set; }
    }
}
