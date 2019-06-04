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
    public class Tb07002PermissoesController : ControllerBase
    {
        private readonly TESTEContext _context;

        public Tb07002PermissoesController(TESTEContext context)
        {
            _context = context;
        }

        // GET: api/Tb07002Permissoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tb07002Permissoes>>> GetTb07002Permissoes()
        {
            return await _context.Tb07002Permissoes.ToListAsync();
        }

        // GET: api/Tb07002Permissoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tb07002Permissoes>> GetTb07002Permissoes(int id)
        {
            var tb07002Permissoes = await _context.Tb07002Permissoes.FindAsync(id);

            if (tb07002Permissoes == null)
            {
                return NotFound();
            }

            return tb07002Permissoes;
        }

        // PUT: api/Tb07002Permissoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTb07002Permissoes(int id, Tb07002Permissoes tb07002Permissoes)
        {
            if (id != tb07002Permissoes.PermissoesId)
            {
                return BadRequest();
            }

            _context.Entry(tb07002Permissoes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tb07002PermissoesExists(id))
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

        // POST: api/Tb07002Permissoes
        [HttpPost]
        public async Task<ActionResult<Tb07002Permissoes>> PostTb07002Permissoes(Tb07002Permissoes tb07002Permissoes)
        {
            _context.Tb07002Permissoes.Add(tb07002Permissoes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTb07002Permissoes", new { id = tb07002Permissoes.PermissoesId }, tb07002Permissoes);
        }

        // DELETE: api/Tb07002Permissoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tb07002Permissoes>> DeleteTb07002Permissoes(int id)
        {
            var tb07002Permissoes = await _context.Tb07002Permissoes.FindAsync(id);
            if (tb07002Permissoes == null)
            {
                return NotFound();
            }

            _context.Tb07002Permissoes.Remove(tb07002Permissoes);
            await _context.SaveChangesAsync();

            return tb07002Permissoes;
        }

        private bool Tb07002PermissoesExists(int id)
        {
            return _context.Tb07002Permissoes.Any(e => e.PermissoesId == id);
        }
    }
}
