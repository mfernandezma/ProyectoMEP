using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoMEP.Models.ViewModels
{
    public class ListRolesViewModels
    {
        [Display(Name = "ID de Rol")]
        public int ID_Rol { get; set; }

        [Display(Name = "Nombre de Rol")]
        public string Nombre_Rol { get; set; }
    }
}