using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlaylistApi.Data;
using PlaylistApi.Models;

namespace PlaylistApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamsController : ControllerBase
    {
        private readonly PlaylistContext _context;

        public StreamsController(PlaylistContext context)
        {
            _context = context;
        }

        // GET: api/Streams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Streams>>> GetStreams()
        {
            return await _context.Streams.ToListAsync();
        }

        // GET: api/Streams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Streams>> GetStreams(int id)
        {
            var streams = await _context.Streams.FindAsync(id);

            if (streams == null)
            {
                return NotFound();
            }

            return streams;
        }

        // PUT: api/Streams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStreams(int id, Streams streams)
        {
            if (id != streams.Id)
            {
                return BadRequest();
            }

            _context.Entry(streams).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StreamsExists(id))
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

        // POST: api/Streams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Streams>> PostStreams(Streams streams)
        {
            _context.Streams.Add(streams);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStreams", new { id = streams.Id }, streams);
        }

        // DELETE: api/Streams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStreams(int id)
        {
            var streams = await _context.Streams.FindAsync(id);
            if (streams == null)
            {
                return NotFound();
            }

            _context.Streams.Remove(streams);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StreamsExists(int id)
        {
            return _context.Streams.Any(e => e.Id == id);
        }
    }
}
