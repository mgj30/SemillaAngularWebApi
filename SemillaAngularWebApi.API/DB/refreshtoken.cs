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
    
    public partial class refreshtoken
    {
        public int idRefreshToken { get; set; }
        public string Subject { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<System.DateTime> IssuedUtc { get; set; }
        public Nullable<System.DateTime> ExpiresUtc { get; set; }
        public string ProtectedTicket { get; set; }
    
        public virtual usuarios usuarios { get; set; }
    }
}