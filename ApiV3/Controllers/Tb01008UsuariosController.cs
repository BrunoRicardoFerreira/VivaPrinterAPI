using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DalUnlocker;
using Microsoft.AspNetCore.Cors;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [ApiController]
    public class Tb01008UsuariosController : ControllerBase
    {
        private readonly TESTEContext _context = new TESTEContext();

        // GET: api/Tb01008Usuarios
        [HttpGet]
        public IEnumerable<Tb01008Usuarios> GetTb01008Usuarios()
        {
            return _context.Tb01008Usuarios;
        }

        // GET: api/Tb01008Usuarios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTb01008Usuarios([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tb01008Usuarios = await _context.Tb01008Usuarios.FindAsync(id);

            if (tb01008Usuarios == null)
            {
                return NotFound();
            }

            return Ok(tb01008Usuarios);
        }

        // PUT: api/Tb01008Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTb01008Usuarios([FromRoute] int id, [FromBody] Tb01008Usuarios tb01008Usuarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb01008Usuarios.UsuarioId)
            {
                return BadRequest();
            }

            _context.Entry(tb01008Usuarios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tb01008UsuariosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tb01008Usuarios
        [HttpPost]
        public async Task<IActionResult> PostTb01008Usuarios([FromBody] Tb01008Usuarios tb01008Usuarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tb01008Usuarios.Add(tb01008Usuarios);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Tb01008UsuariosExists(tb01008Usuarios.UsuarioId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTb01008Usuarios", new { id = tb01008Usuarios.UsuarioId }, tb01008Usuarios);
        }

        // DELETE: api/Tb01008Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTb01008Usuarios([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tb01008Usuarios = await _context.Tb01008Usuarios.FindAsync(id);
            if (tb01008Usuarios == null)
            {
                return NotFound();
            }

            _context.Tb01008Usuarios.Remove(tb01008Usuarios);
            await _context.SaveChangesAsync();

            return Ok(tb01008Usuarios);
        }

        private bool Tb01008UsuariosExists(int id)
        {
            return _context.Tb01008Usuarios.Any(e => e.UsuarioId == id);
        }
    }
}