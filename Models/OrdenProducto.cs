using System;
using System.Collections;
using System.Text.Json.Serialization;

namespace menuActividd2.Models;

public class OrdenProducto
{
    public Guid OrdenId { get; set; }
    public Guid ProductoId { get; set; }
    public int Cantidad { get; set; }

    public Orden? Orden { get; set; }
    public Producto? Producto { get; set; }
}