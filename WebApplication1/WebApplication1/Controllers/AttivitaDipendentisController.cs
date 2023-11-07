using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttivitaDipendentisController : ControllerBase
    {
        private readonly EmployerContext _context;

        public AttivitaDipendentisController(EmployerContext context)
        {
            _context = context;
        }

        // GET: api/AttivitaDipendentis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttivitaDipendenti>>> GetAttivitaDipendentis()
        {
          if (_context.AttivitaDipendentis == null)
          {
              return NotFound();
          }
            return await _context.AttivitaDipendentis.ToListAsync();
        }

        // GET: api/AttivitaDipendentis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AttivitaDipendenti>> GetAttivitaDipendenti(int id)
        {
          if (_context.AttivitaDipendentis == null)
          {
              return NotFound();
          }
            var attivitaDipendenti = await _context.AttivitaDipendentis.FindAsync(id);

            if (attivitaDipendenti == null)
            {
                return NotFound();
            }

            return attivitaDipendenti;
        }

        // PUT: api/AttivitaDipendentis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttivitaDipendenti(int id, AttivitaDipendenti attivitaDipendenti)
        {
            if (id != attivitaDipendenti.Id)
            {
                return BadRequest();
            }

            _context.Entry(attivitaDipendenti).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttivitaDipendentiExists(id))
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

        // POST: api/AttivitaDipendentis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AttivitaDipendenti>> PostAttivitaDipendenti(AttivitaDipendenti attivitaDipendenti)
        {
          if (_context.AttivitaDipendentis == null)
          {
              return Problem("Entity set 'EmployerContext.AttivitaDipendentis'  is null.");
          }
            _context.AttivitaDipendentis.Add(attivitaDipendenti);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttivitaDipendenti", new { id = attivitaDipendenti.Id }, attivitaDipendenti);
        }

        // DELETE: api/AttivitaDipendentis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttivitaDipendenti(int id)
        {
            if (_context.AttivitaDipendentis == null)
            {
                return NotFound();
            }
            var attivitaDipendenti = await _context.AttivitaDipendentis.FindAsync(id);
            if (attivitaDipendenti == null)
            {
                return NotFound();
            }

            _context.AttivitaDipendentis.Remove(attivitaDipendenti);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AttivitaDipendentiExists(int id)
        {
            return (_context.AttivitaDipendentis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
