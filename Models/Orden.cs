using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace menuActividd2.Models;

public class Orden
{
    public Guid? Id { get; set; } = new Guid();
    public DateTime Fecha_Orden { get; set; }
    public required Guid UsuarioId { get; set; }
    
    public required Usuario Usuario { get; set; } //Referencia de navegacion
    [JsonIgnore]
    public ICollection<OrdenProducto>? OrdenProductos { get; set; }
}