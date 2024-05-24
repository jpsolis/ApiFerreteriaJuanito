using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class Rol
    {
        [Key]
        public int idRol { get; set; }
        public string rolDescripcion { get; set; } = String.Empty;
    }
}
