using System;
using System.Threading.Tasks;
using menuActividd2.Repository.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace menuActividd2.Controllers.Usuarios;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    
    public UsuariosController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> ObtenerUsuarios()
    {
        var respuesta = await _usuarioRepository
            .ObtenerUsuarios();

        return Ok(respuesta);
    }

    [HttpGet("[action]/{id:guid}")]
    public async Task<IActionResult> ObtenerUsuario(Guid id)
    {
        var respuesta = await _usuarioRepository
            .ObtenerUnUsuario(id);

        if (respuesta.Estado == false)
        {
            return NotFound(respuesta);
        }

        return Ok(respuesta);
    }
    
}