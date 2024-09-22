using System;
using System.Collections.Generic;

namespace menuActividd2.Models;

public class Orden
{
    public string? Id { get; set; }
    public DateTime Fecha_Orden { get; set; }
    public required string UsuarioId { get; set; }
    
    public required Usuario Usuario { get; set; } //Referencia de navegacion
    public ICollection<OrdenProducto>? OrdenProductos { get; set; }
}