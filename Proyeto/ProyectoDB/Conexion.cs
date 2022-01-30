using Microsoft.EntityFrameworkCore;
using Proyecto.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ProyectoDB
{
    public class Conexion : DbContext
    {
        public Conexion(DbContextOptions<Conexion> options)
            : base(options)
        {

        }

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
        protected override void OnModelCreating(ModelBuilder model)
        {
            //configuracion
            //presentacion y producto
            model.Entity<Producto>()
                .HasOne(producto => producto.Presentacion)
                .WithMany(presentacion => presentacion.Producto)
                .HasForeignKey(producto => producto.cod_Presentacion);
            //Distrito y proveedor
            model.Entity<Proveedor>()
                .HasOne(proveedor => proveedor.Distrito)
                .WithMany(distrito => distrito.Proveedor)
                .HasForeignKey(proveedor => proveedor.cod_Proveedor);
            //Distrito y cliente
            model.Entity<Cliente>()
                .HasOne(cliente => cliente.Distrito)
                .WithMany(distrito => distrito.Cliente)
                .HasForeignKey(cliente => cliente.cod_Distrito);
            //Distrito y empleado
            model.Entity<Empleado>()
                .HasOne(empleado => empleado.Distrito)
                .WithMany(distrito => distrito.Empleado)
                .HasForeignKey(Distrito => Distrito.cod_Empleado);
            //productos y detalleorden
            model.Entity<DetalleOrdenPedido>()
                .HasOne(detalleordenpedido => detalleordenpedido.Producto)
                .WithMany(producto => producto.DetalleOrdenPedido)
                .HasForeignKey(detalleordenpedido => detalleordenpedido.num_OrdenPedido);
            //categoria y producto
            model.Entity<Producto>()
                .HasOne(producto => producto.Categoria)
                .WithMany(categoria => categoria.Producto)
                .HasForeignKey(producto => producto.cod_Categoria);
            //Proveedor y Producto
            model.Entity<Producto>()
                .HasOne(producto => producto.Proveedor)
                .WithMany(proveedor => proveedor.Producto)
                .HasForeignKey(producto => producto.cod_Proveedor);
            //cliente y ordenpedido
            model.Entity<OrdenPedido>()
                .HasOne(ordenpedido => ordenpedido.Cliente)
                .WithMany(cliente => cliente.OrdenPedido)
                .HasForeignKey(ordenpedido => ordenpedido.cod_Cliente);
            //Ordenpedido y boleta
            model.Entity<Boleta>()
                .HasOne(boleta => boleta.OrdenPedido)
                .WithMany(ordenpedido => ordenpedido.Boleta)
                .HasForeignKey(boleta => boleta.num_OrdenPedido);
            //empleado y ordenpedido
            model.Entity<OrdenPedido>()
                .HasOne(ordenpedido => ordenpedido.Empleado)
                .WithMany(empleado => empleado.OrdenPedido)
                .HasForeignKey(ordenpedido => ordenpedido.cod_Empleado);
            //empleado y usuario
            model.Entity<Usuario>()
                .HasOne(usuario => usuario.Empleado)
                .WithMany(empleado => empleado.Usuario)
                .HasForeignKey(usuario => usuario.cod_Empleado);


        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        //{
        //    opciones.UseSqlServer("Server= CARLOS ; initial catalog = Farmacia_Pro; trusted_connection = true; ");

        //    //opciones.UseNpgsql(" Host = localhost; Database = Insti; Username = postgres; Password = carlos00; ");

        //}
    }
}
