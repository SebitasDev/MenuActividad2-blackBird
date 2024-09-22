using System;
using System.Collections;
using System.Text.Json.Serialization;

namespace menuActividd2.Models;

public class OrdenProducto
{
    public required Guid OrdenId { get; set; }
    public required Guid ProductoId { get; set; }
    public required int Cantidad { get; set; }

    public required Orden Orden { get; set; }
    public required Producto Producto { get; set; }
}