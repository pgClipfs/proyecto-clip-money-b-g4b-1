using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Moneda
    {
        /// <summary>
        /// Es el id de Moneda
        /// </summary>
        public int id_moneda { get; set; }
        /// <summary>
        /// Es el nombre de Moneda
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// Es la abreviacion de Moneda
        /// </summary>
        public string abreviación { get; set; }
       /// <summary>
       /// Es la descripcion de Moneda
       /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es el estado de Moneda
        /// </summary>
        public bool estado { get; set; }
        /// <summary>
        /// Es la cotizacion de Moneda
        /// </summary>
        public double cotizacion { get; set; }
        
    }
}
