//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clipMoney.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Cuentas = new HashSet<Cuentas>();
        }
    
        public int usuario { get; set; }
        public string nombre_titular { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public int DNI { get; set; }
        public string calle_direccion { get; set; }
        public int numero_direccion { get; set; }
        public int id_barrio { get; set; }
        public string apellido_titular { get; set; }
    
        public virtual Barrios Barrios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas> Cuentas { get; set; }
    }
}