﻿using System;
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
    public class SpeciesesController : ControllerBase
    {
        private readonly BirdsOfTheRedBookOfUkraineDBContext _context;

        public SpeciesesController(BirdsOfTheRedBookOfUkraineDBContext context)
        {
            _context = context;
        }

        // GET: api/Specieses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Species>>> GetSpecieses()
        {
            return await _context.Specieses.ToListAsync();
        }

        // GET: api/Specieses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Species>> GetSpecies(int id)
        {
            var species = await _context.Specieses.FindAsync(id);

            if (species == null)
            {
                return NotFound();
            }

            return species;
        }

        // PUT: api/Specieses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecies(int id, Species species)
        {
            if (id != species.Id)
            {
                return BadRequest();
            }

            _context.Entry(species).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeciesExists(id))
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

        // POST: api/Specieses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Species>> PostSpecies(Species species)
        {
            _context.Specieses.Add(species);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecies", new { id = species.Id }, species);
        }

        // DELETE: api/Specieses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Species>> DeleteSpecies(int id)
        {
            var species = await _context.Specieses.FindAsync(id);
            if (species == null)
            {
                return NotFound();
            }

            _context.Specieses.Remove(species);
            await _context.SaveChangesAsync();

            return species;
        }

        private bool SpeciesExists(int id)
        {
            return _context.Specieses.Any(e => e.Id == id);
        }
    }
}
