using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnagraficaGeneralesController : ControllerBase
    {
        private readonly EmployerContext _context;

        public AnagraficaGeneralesController(EmployerContext context)
        {
            _context = context;
        }

        // GET: api/AnagraficaGenerales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnagraficaGenerale>>> GetAnagraficaGenerales()
        {
            if (_context.AnagraficaGenerales == null)
            {
                return NotFound();
            }

            return await _context.AnagraficaGenerales
            .Include(emp => emp.AttivitaDipendentis)
            .ToListAsync();
        }

        // GET: api/AnagraficaGenerales/5
        [HttpGet("{phone}")]
        public async Task<ActionResult<AnagraficaGenerale>> GetAnagraficaGenerale(string phone)
        {
            if (_context.AnagraficaGenerales == null)
                return NotFound();

            var employee = await _context.AnagraficaGenerales.FirstOrDefaultAsync(e => e.Telefono.Trim() == phone);

            if (employee == null)
                return NotFound();

            return employee;
        }

        // PUT: api/AnagraficaGenerales/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnagraficaGenerale(string id, AnagraficaGenerale anagraficaGenerale)
        {
            if (id != anagraficaGenerale.Matricola)
            {
                return BadRequest();
            }

            foreach (AttivitaDipendenti att in anagraficaGenerale.AttivitaDipendentis)
                att.MatricolaNavigation = att.MatricolaNavigation != null ? null : att.MatricolaNavigation;

            _context.Entry(anagraficaGenerale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!AnagraficaGeneraleExists(id))
            {
                if (!AnagraficaGeneraleExists(id))
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

        // POST: api/AnagraficaGenerales
        [HttpPost]
        public async Task<ActionResult<AnagraficaGenerale>> PostAnagraficaGenerale(AnagraficaGenerale anagraficaGenerale)
        {
            if (_context.AnagraficaGenerales == null)
            {
                return Problem("Entity set 'EmployerContext.AnagraficaGenerales'  is null.");
            }

            foreach (AttivitaDipendenti att in anagraficaGenerale.AttivitaDipendentis)
                att.MatricolaNavigation = att.MatricolaNavigation != null ? null : att.MatricolaNavigation;

            _context.AnagraficaGenerales.Add(anagraficaGenerale);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnagraficaGeneraleExists(anagraficaGenerale.Matricola))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnagraficaGenerale", new { id = anagraficaGenerale.Matricola }, anagraficaGenerale);
        }

        // DELETE: api/AnagraficaGenerales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnagraficaGenerale(string id)
        {
            if (_context.AnagraficaGenerales == null)
            {
                return NotFound();
            }

            var anagraficaGenerale = await _context.AnagraficaGenerales.FindAsync(id);

            if (anagraficaGenerale == null)
            {
                return NotFound();
            }

            _context.AnagraficaGenerales.Remove(anagraficaGenerale);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnagraficaGeneraleExists(string id)
        {
            return (_context.AnagraficaGenerales?.Any(e => e.Matricola == id)).GetValueOrDefault();
        }
    }
}
