using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_5_2.Models
{
    public class Clientes : Cliente
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre debe tener un minimo de 3 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MinLength(3, ErrorMessage = "El apellido debe tener un minimo de 3 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]
        [MinLength(5, ErrorMessage = "La direccion debe tener un minimo de 5 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [MinLength(12, ErrorMessage = "El telefono debe tener un minimo de 12 caracteres. por ejemplo: 809-123-4567")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La cedula es obligatoria")]
        [MinLength(13, ErrorMessage = "La cedula debe tener 13 caracteres. por ejemplo: 123-4567890-1")]
        public string Cedula { get; set; }
    }
}