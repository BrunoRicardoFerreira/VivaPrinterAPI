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
    public class Tb07003AdministradorController : ControllerBase
    {
        private readonly TESTEContext _context;

        public Tb07003AdministradorController(TESTEContext context)
        {
            _context = context;
        }

        // GET: api/Tb07003Administrador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tb07003Administrador>>> GetTb07003Administrador()
        {
            return await _context.Tb07003Administrador.ToListAsync();
        }

        // GET: api/Tb07003Administrador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tb07003Administrador>> GetTb07003Administrador(int id)
        {
            var tb07003Administrador = await _context.Tb07003Administrador.FindAsync(id);

            if (tb07003Administrador == null)
            {
                return NotFound();
            }

            return tb07003Administrador;
        }

        // PUT: api/Tb07003Administrador/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTb07003Administrador(int id, Tb07003Administrador tb07003Administrador)
        {
            if (id != tb07003Administrador.AdministradorId)
            {
                return BadRequest();
            }

            _context.Entry(tb07003Administrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tb07003AdministradorExists(id))
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

        // POST: api/Tb07003Administrador
        [HttpPost]
        public async Task<ActionResult<Tb07003Administrador>> PostTb07003Administrador(Tb07003Administrador tb07003Administrador)
        {
            _context.Tb07003Administrador.Add(tb07003Administrador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTb07003Administrador", new { id = tb07003Administrador.AdministradorId }, tb07003Administrador);
        }

        // DELETE: api/Tb07003Administrador/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tb07003Administrador>> DeleteTb07003Administrador(int id)
        {
            var tb07003Administrador = await _context.Tb07003Administrador.FindAsync(id);
            if (tb07003Administrador == null)
            {
                return NotFound();
            }

            _context.Tb07003Administrador.Remove(tb07003Administrador);
            await _context.SaveChangesAsync();

            return tb07003Administrador;
        }

        private bool Tb07003AdministradorExists(int id)
        {
            return _context.Tb07003Administrador.Any(e => e.AdministradorId == id);
        }
    }
}
