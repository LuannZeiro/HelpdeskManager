
using HelpdeskManager.Domain;
using HelpdeskManager.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelpdeskManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadosController : ControllerBase
    {
        private readonly HelpdeskDbContext _context;

        public ChamadosController(HelpdeskDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chamado>>> Get() =>
            Ok(await _context.Chamados.ToListAsync());

        [HttpPost]
        public async Task<ActionResult<Chamado>> Post(Chamado chamado)
        {
            chamado.DataAbertura = DateTime.Now;
            _context.Chamados.Add(chamado);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = chamado.Id }, chamado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Chamado chamado)
        {
            if (id != chamado.Id) return BadRequest();
            _context.Entry(chamado).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(chamado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var chamado = await _context.Chamados.FindAsync(id);
            if (chamado == null) return NotFound();
            _context.Chamados.Remove(chamado);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
