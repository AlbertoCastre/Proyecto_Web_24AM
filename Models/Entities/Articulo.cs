using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb24AM_NET._7.Entities
{
    public class Articulo
    {
        [Key]
        public int PkArticulo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]

        public string Descripcion { get; set; }
        [Required]

        public string Precio { get; set; }
    }
}
