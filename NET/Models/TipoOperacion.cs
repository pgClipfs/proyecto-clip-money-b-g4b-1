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
    
    public partial class TipoOperacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoOperacion()
        {
            this.Operaciones = new HashSet<Operaciones>();
        }
    
        public int id_tipo_operacion { get; set; }
        public string descripcion { get; set; }
        public Nullable<bool> estado { get; set; }
        public string nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operaciones> Operaciones { get; set; }
    }
}