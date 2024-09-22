using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace menuActividd2.Models;

public class Usuario
{
    public Guid? Id { get; set; } = new Guid();
    public required string Nombres { get; set; }
    public required string Apellidos { get; set; }
    public required string Correo { get; set; }
    
    [JsonIgnore]
    public ICollection<Orden>? Ordenes { get; set; } //Collecion de referencia
}