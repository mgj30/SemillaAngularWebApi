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
    
    public partial class mail_message_users
    {
        public int idmail_message_users { get; set; }
        public Nullable<int> id_mailmessage { get; set; }
        public Nullable<int> id_user { get; set; }
    
        public virtual mail_message mail_message { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}