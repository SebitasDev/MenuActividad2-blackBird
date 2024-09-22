using System.Collections;

namespace menuActividd2.Models;

public class Producto
{
    public string? Id { get; set; }
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
    public double Precio { get; set; }
    
    public ICollection<OrdenProducto>? OrdenProductos { get; set; }
}