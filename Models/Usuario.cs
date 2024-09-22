using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace menuActividd2.Models;

public class Usuario
{
    public Guid? Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Correo { get; set; }
    
    [JsonIgnore]
    public ICollection<Orden>? Ordenes { get; set; } //Collecion de referencia

    public Usuario()
    {
        if (Id == null || Id == Guid.Empty)
        {
            Id = Guid.NewGuid();
        }
    }
}