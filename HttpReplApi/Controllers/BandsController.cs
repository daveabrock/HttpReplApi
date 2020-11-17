using HttpReplApi.Data;
using Microsoft.AspNetCore.Mvc;
using HttpReplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpReplApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class BandsController : ControllerBase
    {
        private readonly SampleContext _context;

        public BandsController(SampleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Band>> Get() =>
            _context.Bands.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<Band>> GetById(int id)
        {
            var band = await _context.Bands.FindAsync(id);

            if (band == null)
            {
                return NotFound();
            }

            return band;
        }

        [HttpPost]
        public async Task<ActionResult<Band>> Create(Band band)
        {
            _context.Bands.Add(band);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = band.Id }, band);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Band band)
        {
            if (id != band.Id)
            {
                return BadRequest();
            }

            _context.Entry(band).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(int id)
        {
            var band = await _context.Bands.FindAsync(id);

            if (band == null)
            {
                return NotFound();
            }

            _context.Bands.Remove(band);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
