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
    
    public partial class bitacora
    {
        public int id_bitacora { get; set; }
        public string accion { get; set; }
        public string afectado { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<System.DateTime> fecha_hora { get; set; }
    }
}