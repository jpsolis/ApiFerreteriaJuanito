using System.ComponentModel.DataAnnotations;

namespace ApiFerreteriaJuanito
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; } = string.Empty;
        public string passUsuario { get; set; } = string.Empty;
        public string rangoUsuario { get; set; } = string.Empty;
        
    }
}
