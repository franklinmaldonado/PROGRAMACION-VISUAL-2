using Microsoft.EntityFrameworkCore;
using Proyecto.Entidades;

namespace ProyectoDB
{
    public class Conexion : DbContext
    {

        public DbSet<Boleta> Boletas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleOrdenPedido> DetalleOrdenPedidos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<OrdenPedido> OrdenPedidos { get; set; }
        public DbSet<Presentacion> Presentaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //confirgurar el modelo 
        protected override void OnModelCreating (ModelBuilder model)
        {
            //configuracion
            //presentacion y producto
            model.Entity<Presentacion>()
                .HasOne(Presentacion => Presentacion.Productos)
                .WithOne(Producto => Producto.Presentacion)
                .HasForeignKey(Presentacion => Presentacion.cod_Presentacion);
            //Distrito y proveedor
            model.Entity<Distrito>()
                .HasOne(distrito => distrito.Proveedores)
                .WithMany(Proveedor => Proveedor.Distritos)
                .HasForeignKey(Distrito => Distrito.cod_Proveedor);
            //Distrito y cliente
            model.Entity<Distrito>()
                .HasOne(distrito => distrito.Clientes)
                .WithMany(cliente => cliente.Distritos)
                .HasForeignKey(Distrito => Distrito.cod_Cliente);
            //Distrito y producto
            model.Entity<Distrito>()
                .HasOne(distrito => distrito.Empleados)
                .WithMany(Empleado =>Empleado.Distritos )
                .HasForeignKey(Distrito => Distrito.cod_Empleado);
            //productos y detalleorden
            model.Entity<Producto>()
                .HasOne(produtos => Producto.DetalleOrdenPedido)
                .WithMany(DetalleOrdenPedido => DetalleOrdenPedido.Productos)
                .HasForeignKey(Producto => Producto.num_OrdenPedido);
            //categoria y producto
            model.Entity<Categoria>()
                .HasOne(categoria => categoria.Productos)
                .WithMany(Producto => Producto.Categorias)
                .HasForeignKey(Categoria => Categoria.cod_Producto);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("Server= CARLOS ; initial catalog = Farmacia_Pro; trusted_connection = true; ");

            //opciones.UseNpgsql(" Host = localhost; Database = Insti; Username = postgres; Password = carlos00; ");

        }
    }
}
