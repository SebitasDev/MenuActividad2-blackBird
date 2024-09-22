using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace menuActividd2.Models;

public class Producto
{
    public Guid? Id { get; set; } = new Guid();
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }
    
    [JsonIgnore]
    public ICollection<OrdenProducto>? OrdenProductos { get; set; }
}