using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_5_2.Models
{
    public class Productos : Producto
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Cantidad es obligatoria")]
        [MinLength(1, ErrorMessage = "Debe contener mas de (1) un articulo")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        [Range(5,2500,ErrorMessage = "El precio debe oscilar entre los RD$5.00 y los RD$2,500.00 pesos dominicanos")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "La cantidad en Stock debe llenarse")]
        [MinLength(1, ErrorMessage = "Debe al menos tener un numero mayor a cero (0)")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "El Estado es obligatorio : Bueno, Malo, Nuevo...")]
        public string Estado { get; set; }
    }
}