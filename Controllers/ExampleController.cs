using System.Threading.Tasks;
using menuActividd2.Data;
using menuActividd2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace menuActividd2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExampleController : ControllerBase
{
    private readonly MenuContext _context;

    public ExampleController(MenuContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<IActionResult> Example()
    {
        return Ok(
            await _context.Ordenes.Include(
                x => x.Usuario
            ).ToListAsync()
        );
    }

    [HttpPost]
    public async Task<IActionResult> Example2([FromBody] Usuario usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();

        return Ok();
    }

}