//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SemillaAngularWebApi.API.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class boletines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public boletines()
        {
            this.boletines_info = new HashSet<boletines_info>();
        }
    
        public int idboletines { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> id_grupo { get; set; }
        public Nullable<int> id_alumno { get; set; }
    
        public virtual alumno alumno { get; set; }
        public virtual grupos grupos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boletines_info> boletines_info { get; set; }
    }
}
