namespace menuActividd2.Models.DTOs;

public class RespuestaApiDTO<T>
{
    public bool Estado { get; set; }
    public string Mensaje { get; set; }
    public T? Contenido { get; set; }
}