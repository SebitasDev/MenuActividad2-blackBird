using System.Collections;

namespace menuActividd2.Models;

public class OrdenProducto
{
    public required string OrdenId { get; set; }
    public required string ProductoId { get; set; }
    public required int Cantidad { get; set; }
    
    public required Orden Orden { get; set; }
    public required Producto Producto { get; set; }
}