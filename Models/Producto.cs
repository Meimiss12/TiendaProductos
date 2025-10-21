using System.ComponentModel.DataAnnotations;

namespace TiendaProductos.Models
{
    public class Producto
    {
        [Required(ErrorMessage = "El inventario es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El inventario debe ser mayor a 0.")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(200, ErrorMessage = "El nombre no puede tener más de 200 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El departamento es obligatorio.")]
        public string Departamento { get; set; } = string.Empty;
    }
}
