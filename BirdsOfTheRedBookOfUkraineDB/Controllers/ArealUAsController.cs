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
    public class ArealUAsController : ControllerBase
    {
        private readonly BirdsOfTheRedBookOfUkraineDBContext _context;

        public ArealUAsController(BirdsOfTheRedBookOfUkraineDBContext context)
        {
            _context = context;
        }

        // GET: api/ArealUAs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArealUA>>> GetArealUAs()
        {
            return await _context.ArealUAs.ToListAsync();
        }

        // GET: api/ArealUAs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArealUA>> GetArealUA(int id)
        {
            var arealUA = await _context.ArealUAs.FindAsync(id);

            if (arealUA == null)
            {
                return NotFound();
            }

            return arealUA;
        }

        // PUT: api/ArealUAs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArealUA(int id, ArealUA arealUA)
        {
            if (id != arealUA.Id)
            {
                return BadRequest();
            }

            _context.Entry(arealUA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArealUAExists(id))
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

        // POST: api/ArealUAs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ArealUA>> PostArealUA(ArealUA arealUA)
        {
            _context.ArealUAs.Add(arealUA);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArealUA", new { id = arealUA.Id }, arealUA);
        }

        // DELETE: api/ArealUAs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ArealUA>> DeleteArealUA(int id)
        {
            var arealUA = await _context.ArealUAs.FindAsync(id);
            if (arealUA == null)
            {
                return NotFound();
            }

            _context.ArealUAs.Remove(arealUA);
            await _context.SaveChangesAsync();

            return arealUA;
        }

        private bool ArealUAExists(int id)
        {
            return _context.ArealUAs.Any(e => e.Id == id);
        }
    }
}
