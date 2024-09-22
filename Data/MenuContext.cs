using menuActividd2.Models;
using Microsoft.EntityFrameworkCore;

namespace menuActividd2.Data;

public class MenuContext : DbContext
{
    //Constructor que hereda las opciones de dbcontext
    public MenuContext(DbContextOptions<MenuContext> options) : base(options)
    {
        
    }
    
    //Mapeando los modelos con los de la db
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<OrdenProducto> OrdenesProductos { get; set; }
    
    //Referenciando los modelos
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>() // configurando la entidad Usuario
            .HasMany(e => e.Ordenes) //La entidad usuarios tiene una relacion de uno a muchos con orden
            .WithOne(e => e.Usuario) //Orden esta relacionada con un unico usuario
            .HasForeignKey(e => e.UsuarioId) //la propiedad en la entidad orden es una FK que referencia a Usuario
            .HasPrincipalKey(e => e.Id); //Indica que la propiedas en Usuario es la PK

        modelBuilder.Entity<OrdenProducto>() //Configuracion de la relacion uno a muchos
            .HasKey(e => new //Clave compuesta
            {
                e.OrdenId,
                e.ProductoId
            });

        modelBuilder.Entity<Orden>()
            .HasMany(e => e.OrdenProductos)
            .WithOne(e => e.Orden)
            .HasForeignKey(e => e.OrdenId);

        modelBuilder.Entity<Producto>()
            .HasMany(e => e.OrdenProductos)
            .WithOne(e => e.Producto)
            .HasForeignKey(e => e.ProductoId);

    }
}