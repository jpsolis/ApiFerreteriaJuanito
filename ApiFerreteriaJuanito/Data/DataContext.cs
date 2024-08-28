using Microsoft.EntityFrameworkCore;

namespace ApiFerreteriaJuanito.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)  {  }

        public DbSet<Producto>? Productos => Set<Producto>();

        public DbSet<Usuario>? Usuarios { get; set; }

        public DbSet<Rol>? Roles { get; set; }

        public DbSet<CarroCompra>? CarroCompras { get; set; }

        public DbSet <Stock>? Stocks { get; set; }

        public DbSet<DetalleCarro>? DetalleCarros { get; set; }

        //public DbSet<Usuario> Usuarios => Set<Usuario>();

        //public DbSet<Rol> Roles => Set<Rol>();

        //public DbSet<CarroCompra> CarroCompras => Set<CarroCompra>();

        //public DbSet<Stock> Stocks => Set<Stock>();

        //public DbSet<DetalleCarro> DetalleCarros => Set<DetalleCarro>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarroCompra>()
                .HasOne(e => e.DetalleCarro)
                .WithOne(e => e.CarroCompra)
                .HasForeignKey<DetalleCarro>(e => e.CarroCompraId)
                .IsRequired();
        }
    }
}
