using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BirdsOfTheRedBookOfUkraineDB.Models;

namespace BirdsOfTheRedBookOfUkraineDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenusesController : ControllerBase
    {
        private readonly BirdsOfTheRedBookOfUkraineDBContext _context;

        public GenusesController(BirdsOfTheRedBookOfUkraineDBContext context)
        {
            _context = context;
        }

        // GET: api/Genuses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genus>>> GetGenuses()
        {
            return await _context.Genuses.ToListAsync();
        }

        // GET: api/Genuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genus>> GetGenus(int id)
        {
            var genus = await _context.Genuses.FindAsync(id);

            if (genus == null)
            {
                return NotFound();
            }

            return genus;
        }

        // PUT: api/Genuses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenus(int id, Genus genus)
        {
            if (id != genus.Id)
            {
                return BadRequest();
            }

            _context.Entry(genus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenusExists(id))
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

        // POST: api/Genuses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Genus>> PostGenus(Genus genus)
        {
            _context.Genuses.Add(genus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGenus", new { id = genus.Id }, genus);
        }

        // DELETE: api/Genuses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Genus>> DeleteGenus(int id)
        {
            var genus = await _context.Genuses.FindAsync(id);
            if (genus == null)
            {
                return NotFound();
            }

            _context.Genuses.Remove(genus);
            await _context.SaveChangesAsync();

            return genus;
        }

        private bool GenusExists(int id)
        {
            return _context.Genuses.Any(e => e.Id == id);
        }
    }
}
