using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using menuActividd2.Models;
using menuActividd2.Models.DTOs;

namespace menuActividd2.Repository.Usuarios;

public interface IUsuarioRepository
{
    Task<RespuestaApiDTO<List<Usuario>>> ObtenerUsuarios();
    Task<RespuestaApiDTO<Usuario>> ObtenerUnUsuario(Guid id);

}