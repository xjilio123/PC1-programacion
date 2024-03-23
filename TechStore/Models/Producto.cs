using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public required string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0.")]
        public decimal Precio { get; set; }

        public decimal IGV => Precio * 0.18m;
    }
}