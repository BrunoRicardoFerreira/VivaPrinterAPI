using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DalUnlocker;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [ApiController]
    [Authorize]
    public class Tb07001PerfilController : ControllerBase
    {
        private readonly TESTEContext _context;

        public Tb07001PerfilController(TESTEContext context)
        {
            _context = context;
        }

        // GET: api/Tb07001Perfil
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tb07001Perfil>>> GetTb07001Perfil()
        {
            return await _context.Tb07001Perfil.ToListAsync();
        }

        // GET: api/Tb07001Perfil/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tb07001Perfil>> GetTb07001Perfil(int id)
        {
            var tb07001Perfil = await _context.Tb07001Perfil.FindAsync(id);

            if (tb07001Perfil == null)
            {
                return NotFound();
            }

            return tb07001Perfil;
        }

        // PUT: api/Tb07001Perfil/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTb07001Perfil(int id, Tb07001Perfil tb07001Perfil)
        {
            if (id != tb07001Perfil.PerfilId)
            {
                return BadRequest();
            }

            _context.Entry(tb07001Perfil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tb07001PerfilExists(id))
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

        // POST: api/Tb07001Perfil
        [HttpPost]
        public async Task<ActionResult<Tb07001Perfil>> PostTb07001Perfil(Tb07001Perfil tb07001Perfil)
        {
            _context.Tb07001Perfil.Add(tb07001Perfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTb07001Perfil", new { id = tb07001Perfil.PerfilId }, tb07001Perfil);
        }

        // DELETE: api/Tb07001Perfil/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tb07001Perfil>> DeleteTb07001Perfil(int id)
        {
            var tb07001Perfil = await _context.Tb07001Perfil.FindAsync(id);
            if (tb07001Perfil == null)
            {
                return NotFound();
            }

            _context.Tb07001Perfil.Remove(tb07001Perfil);
            await _context.SaveChangesAsync();

            return tb07001Perfil;
        }

        private bool Tb07001PerfilExists(int id)
        {
            return _context.Tb07001Perfil.Any(e => e.PerfilId == id);
        }
    }
}
