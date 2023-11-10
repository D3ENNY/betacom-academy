using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApplication1.Models;
using WebApplication1.Models.DTO;

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
        public async Task<ActionResult<IEnumerable<AnagraficaGeneraleDTO>>> GetAnagraficaGenerales()
        {
            if (_context.AnagraficaGenerales == null)
            {
                return NotFound();
            }

            return await _context.AnagraficaGenerales
            .Include(emp => emp.AttivitaDipendentis)
            .Select(x => AnagraficaToDTO(x))
            .ToListAsync();
        }

        // GET: api/AnagraficaGenerales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnagraficaGeneraleDTO>> GetAnagraficaGenerale(string id)
        {
            if (_context.AnagraficaGenerales == null)
            {
                return NotFound();
            }
            var anagraficaGenerale = await _context.AnagraficaGenerales
                .Include(emp => emp.AttivitaDipendentis)
                .FirstOrDefaultAsync(emp => emp.Matricola == id);

            if (anagraficaGenerale == null)
            {
                return NotFound();
            }

            return AnagraficaToDTO(anagraficaGenerale);
        }

        // PUT: api/AnagraficaGenerales/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnagraficaGenerale(string id, AnagraficaGeneraleDTO anagraficaGenerale)
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
        public async Task<ActionResult<AnagraficaGeneraleDTO>> PostAnagraficaGenerale(AnagraficaGeneraleDTO anagraficaGeneraleDTO)
        {
            if (_context.AnagraficaGenerales == null)
            {
                return Problem("Entity set 'EmployerContext.AnagraficaGenerales'  is null.");
            }

            var anagraficaGenerale = DTOtoAnagrafica(anagraficaGeneraleDTO);

            foreach (AttivitaDipendenti att in anagraficaGeneraleDTO.AttivitaDipendentis)
                att.MatricolaNavigation = att.MatricolaNavigation != null ? null : att.MatricolaNavigation;

            _context.AnagraficaGenerales.Add(anagraficaGenerale);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnagraficaGeneraleExists(anagraficaGeneraleDTO.Matricola))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnagraficaGenerale", new { id = anagraficaGeneraleDTO.Matricola }, anagraficaGenerale);
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

        private static AnagraficaGeneraleDTO AnagraficaToDTO(AnagraficaGenerale anag) =>
           new AnagraficaGeneraleDTO
           {
               Matricola = anag.Matricola,
               Nominativo = anag.Nominativo,
               Ruolo = anag.Ruolo,
               Reparto = anag.Reparto,
               Eta = anag.Eta,
               Indirizzo = anag.Indirizzo,
               Citta = anag.Citta,
               Provincia = anag.Provincia,
               Cap = anag.Cap,
               Telefono = anag.Telefono,
               AttivitaDipendentis = anag.AttivitaDipendentis
            };

        private static AnagraficaGenerale DTOtoAnagrafica(AnagraficaGeneraleDTO anag) =>
           new AnagraficaGenerale
           {
               Matricola = anag.Matricola,
               Nominativo = anag.Nominativo,
               Ruolo = anag.Ruolo,
               Reparto = anag.Reparto,
               Eta = anag.Eta,
               Indirizzo = anag.Indirizzo,
               Citta = anag.Citta,
               Provincia = anag.Provincia,
               Cap = anag.Cap,
               Telefono = anag.Telefono,
               AttivitaDipendentis = anag.AttivitaDipendentis
           };
    }
}
