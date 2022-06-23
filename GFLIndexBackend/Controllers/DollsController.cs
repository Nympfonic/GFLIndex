using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GFLIndexBackend.Models;
using GFLIndexBackend.Models.DTO;
using GFLIndexBackend.Services;

namespace GFLIndexBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DollsController : ControllerBase
    {
        private IGFLService _service;

        public DollsController(IGFLService service)
        {
            if (service == null)
                throw new ArgumentException("IGFLService object cannot be null");

            _service = service;
        }

        // GET: api/Dolls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DollDTO>>> GetDolls()
        {
            var dolls = await _service.GetDollsAsync();
            if (dolls == null)
                return NotFound();

            return dolls.ToList();
        }

        // GET: api/Dolls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DollDTO>> GetDollById(int id)
        {
            var dolls = await _service.GetDollsAsync();
            if (dolls == null)
                return NotFound();

            var doll = await _service.GetDollByIdAsync(id);
            if (doll == null)
                return NotFound();

            return doll;
        }

        // PUT: api/Dolls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDollById(int id, DollDTO dollDto)
        {
            if (id != dollDto.Id)
                return BadRequest();

            await _service.UpdateDollByIdAsync(id, dollDto);

            try
            {
                await _service.SaveDollChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_service.DollExists(id))
                    return NotFound();
                else throw;
            }

            return NoContent();
        }

        // POST: api/Dolls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DollDTO>> PostDoll(DollDTO dollDto)
        {
            var dolls = await _service.GetDollsAsync();
            if (dolls == null)
                return Problem("Entity set 'GFLContext.Dolls' is null.");

            await _service.CreateDollAsync(dollDto);
            await _service.SaveDollChangesAsync();

            return CreatedAtAction("GetDoll", new { id = dollDto.Id }, dollDto);
        }

        // DELETE: api/Dolls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDollById(int id)
        {
            var dolls = await _service.GetDollsAsync();
            if (dolls == null)
                return NotFound();

            var doll = await _service.GetDollByIdAsync(id);
            if (doll == null)
                return NotFound();

            _service.DeleteDollAsync(doll);
            await _service.SaveDollChangesAsync();

            return NoContent();
        }
    }
}
