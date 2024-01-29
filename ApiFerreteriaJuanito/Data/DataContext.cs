using Microsoft.EntityFrameworkCore;

namespace ApiFerreteriaJuanito.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }

        public DbSet<Producto> Productos => Set<Producto>();

        public DbSet<Usuario> Usuarios=> Set<Usuario>();
        public DbSet<CarroCompras> CarroCompras => Set<CarroCompras>();
    }
}
