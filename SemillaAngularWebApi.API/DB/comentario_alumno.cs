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
    
    public partial class comentario_alumno
    {
        public int idcomentario_alumno { get; set; }
        public Nullable<int> id_alumno { get; set; }
        public Nullable<int> id_comentario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string comentario { get; set; }
        public Nullable<int> id_profesor { get; set; }
    
        public virtual alumno alumno { get; set; }
    }
}