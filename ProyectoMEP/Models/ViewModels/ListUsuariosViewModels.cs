using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoMEP.Models.ViewModels
{
    public class ListUsuariosViewModels
    {
        [Display(Name = "ID de Usuario")]
        public int ID_Usuario { get; set; }

        [Display(Name = "ID de Rol")]
        public int ID_Rol { get; set; }

        [Display(Name = "Identificación")]
        public string Identificacion { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido 1")]
        public string Apellido1 { get; set; }

        [Display(Name = "Apellido 2")]
        public string Apellido2 { get; set; }

        [Display(Name = "Contraseña")]
        public string Contrasenna { get; set; }

        [Display(Name = "Correo")]
        public string Correo { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Nacimiento { get; set; }

        [Display(Name = "Rol")]
        public string Rol { get; set; }

    }
}