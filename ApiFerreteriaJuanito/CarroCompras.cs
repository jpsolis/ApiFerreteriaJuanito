using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class CarroCompras
    {
        [Key]
        public int idCarro { get; set; }
        public int idUsuario { get; set; }
        public ICollection<Producto>? listaProductos { get; set; } = new List<Producto>();
    }
}
