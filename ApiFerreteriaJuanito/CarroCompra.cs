using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class CarroCompra
    {
        [Key]
        public int idCarroCompra { get; set; }
        public DetalleCarro? DetalleCarro { get; set; }
        public int totalCompra { get; set; }
    }
}
