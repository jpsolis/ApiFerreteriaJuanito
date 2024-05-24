using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class Stock
    {
        [Key]
        public int idStock { get; set; }
        public Producto? producto { get; set; }
        public int stockDisponible { get; set; }
    }
}
