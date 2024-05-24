using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class DetalleCarro
    {
        [Key]
        [Required]
        public int IdDetalleCarro { get; set; }

        public int CarroCompraId { get; set; }

        public CarroCompra? CarroCompra { get; set; }
       
        public ICollection<Producto>? Productos { get; set; }



    }
}
