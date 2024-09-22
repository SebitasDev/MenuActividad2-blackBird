namespace menuActividd2.Models;

public class Usuario
{
    public string? Id { get; set; }
    public required string Nombres { get; set; }
    public required string Apellidos { get; set; }
    public required string Correo { get; set; }
    
    public ICollection<Orden>? Ordenes { get; set; } //Collecion de referencia
}