using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using menuActividd2.Data;
using menuActividd2.Models;
using menuActividd2.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace menuActividd2.Repository.Usuarios;

public class UsuarioRepository : IUsuarioRepository
{
    private MenuContext _context;
    
    public UsuarioRepository(MenuContext context)
    {
        _context = context;
    }


    public async Task<RespuestaApiDTO<List<Usuario>>> ObtenerUsuarios()
    {
        RespuestaApiDTO<List<Usuario>> respuesta = new RespuestaApiDTO<List<Usuario>>();
        try
        {
            //Obteniendo la lista de usuarios
            List<Usuario> listaUsuarios = await _context.Usuarios
                .Include(u => u.Ordenes)
                .ToListAsync();

            //Seteando la respuesta
            respuesta.Estado = true;
            respuesta.Mensaje = "Usuarios obtenidos correctamente";
            respuesta.Contenido = listaUsuarios;

            //Retorno de respuesta
            return respuesta;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<RespuestaApiDTO<Usuario>> ObtenerUnUsuario(Guid id)
    {
        RespuestaApiDTO<Usuario> respuesta = new RespuestaApiDTO<Usuario>();
        try
        {
            Usuario? usuario = await _context.Usuarios
                .Include(u => u.Ordenes)
                .Where(x => x.Id == id).SingleOrDefaultAsync();
            
            respuesta.Estado = true;
            respuesta.Mensaje = "Usuario encontrado correctamente";
            if (usuario == null)
            {
                respuesta.Mensaje = "Usuario no encontrado";
                respuesta.Estado = false;
            }
            
            respuesta.Contenido = usuario;

            return respuesta;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}