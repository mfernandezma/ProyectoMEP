//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoMEP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int id_usuario { get; set; }
        public Nullable<int> id_rol { get; set; }
        public Nullable<int> identificacion { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string contrasenna { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
