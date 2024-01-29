using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }
        public string descripcion { get; set; } = string.Empty;
        public int precio { get; set; }       
    }
}