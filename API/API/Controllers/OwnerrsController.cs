using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerrsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OwnerrsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Ownerrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ownerr>>> GetOwnerr()
        {
                   
            return await _context.Ownerr.ToListAsync();
        }

        // GET: api/Ownerrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ownerr>> GetOwnerr(int id)
        {
            var ownerr = await _context.Ownerr.FindAsync(id);

            if (ownerr == null)
            {
                return NotFound();
            }

            return ownerr;
        }

        // PUT: api/Ownerrs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOwnerr(int id, Ownerr ownerr)
        {
            if (id != ownerr.idOwner)
            {
                return BadRequest();
            }

            _context.Entry(ownerr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwnerrExists(id))
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

        // POST: api/Ownerrs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ownerr>> PostOwnerr(Ownerr ownerr)
        {
            _context.Ownerr.Add(ownerr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOwnerr", new { id = ownerr.idOwner }, ownerr);
        }

        // DELETE: api/Ownerrs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwnerr(int id)
        {
            var ownerr = await _context.Ownerr.FindAsync(id);
            if (ownerr == null)
            {
                return NotFound();
            }

            _context.Ownerr.Remove(ownerr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OwnerrExists(int id)
        {
            return _context.Ownerr.Any(e => e.idOwner == id);
        }
    }
}
