using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerParcialDLJAPI.Data;
using PrimerParcialDLJAPI.Models;

namespace PrimerParcialDLJAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly AppDbContext _context;

    public EventsController(AppDbContext context) => _context = context;

    // GET: api/events
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Event>>> GetEvents() =>
        await _context.Events.ToListAsync();

    // GET: api/events/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEvent(int id)
    {
        var @event = await _context.Events.FindAsync(id);
        return @event == null ? NotFound() : @event;
    }

    // POST: api/events
    [HttpPost]
    public async Task<ActionResult<Event>> PostEvent(Event @event)
    {
        _context.Events.Add(@event);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetEvent), new { id = @event.Id }, @event);
    }

    // PUT: api/events/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutEvent(int id, Event @event)
    {
        if (id != @event.Id) return BadRequest();
        _context.Entry(@event).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EventExists(id)) return NotFound();
            throw;
        }
        return NoContent();
    }

    // DELETE: api/events/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEvent(int id)
    {
        var @event = await _context.Events.FindAsync(id);
        if (@event == null) return NotFound();
        _context.Events.Remove(@event);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private bool EventExists(int id) => _context.Events.Any(e => e.Id == id);
}