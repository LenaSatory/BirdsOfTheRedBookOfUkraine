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
    public class BirdPhotoesController : ControllerBase
    {
        private readonly BirdsOfTheRedBookOfUkraineDBContext _context;

        public BirdPhotoesController(BirdsOfTheRedBookOfUkraineDBContext context)
        {
            _context = context;
        }

        // GET: api/BirdPhotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BirdPhoto>>> GetBirdPhotos()
        {
            return await _context.BirdPhotos.ToListAsync();
        }

        // GET: api/BirdPhotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BirdPhoto>> GetBirdPhoto(int id)
        {
            var birdPhoto = await _context.BirdPhotos.FindAsync(id);

            if (birdPhoto == null)
            {
                return NotFound();
            }

            return birdPhoto;
        }

        // PUT: api/BirdPhotoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBirdPhoto(int id, BirdPhoto birdPhoto)
        {
            if (id != birdPhoto.Id)
            {
                return BadRequest();
            }

            _context.Entry(birdPhoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BirdPhotoExists(id))
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

        // POST: api/BirdPhotoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BirdPhoto>> PostBirdPhoto(BirdPhoto birdPhoto)
        {
            _context.BirdPhotos.Add(birdPhoto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBirdPhoto", new { id = birdPhoto.Id }, birdPhoto);
        }

        // DELETE: api/BirdPhotoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BirdPhoto>> DeleteBirdPhoto(int id)
        {
            var birdPhoto = await _context.BirdPhotos.FindAsync(id);
            if (birdPhoto == null)
            {
                return NotFound();
            }

            _context.BirdPhotos.Remove(birdPhoto);
            await _context.SaveChangesAsync();

            return birdPhoto;
        }

        private bool BirdPhotoExists(int id)
        {
            return _context.BirdPhotos.Any(e => e.Id == id);
        }
    }
}
