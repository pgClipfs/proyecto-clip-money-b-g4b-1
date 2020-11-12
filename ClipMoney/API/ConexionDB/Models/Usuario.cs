using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Usuario
    {
        /// <summary>
        /// Es el identificador de Usuario
        /// </summary>
        public string usuario { get; set; }
        /// <summary>
        /// Es el nombre del dueño del Usuario
        /// </summary>
        public string nombre_titular { get; set; }
        /// <summary>
        /// Es el apellido del dueño del Usuario
        /// </summary>
        public string apellido_titular { get; set; }
        /// <summary>
        /// Es la contraseña del Usuario
        /// </summary>
        public string contrasenia { get; set; }
        /// <summary>
        /// Es el telefono del Usuario
        /// </summary>
        public string telefono { get; set; }
        /// <summary>
        /// Es el mail asociado al Usuario
        /// </summary>
        public string mail { get; set; }
        /// <summary>
        /// Es la fecha de nacimiento del Usuario
        /// </summary>
        public DateTime fecha_nacimiento { get; set; }
        /// <summary>
        /// Es el DNI del Usuario
        /// </summary>
        public int DNI { get; set; }
        /// <summary>
        /// Es la calle de la direccion del Usuario
        /// </summary>
        public string calle_direccion { get; set; }
        /// <summary>
        /// Es el numero de la direccion del Usuario
        /// </summary>
        public int numero_direccion { get; set; }
        /// <summary>
        /// Es el objeto Barrio de Usuario
        /// </summary>
        public Barrio barrio { get; set; }
        /// <summary>
        /// Es el id del barrio de Usuario
        /// </summary>
        public int id_barrio { get; set; }
    }
}
