using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController(ApplicationDbContext context) : BaseController
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Activity>>> GetActivitiesAsync()
    {
        return Ok(await context.Activities.ToListAsync());
    }
    
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Activity>> GetActivityAsync(Guid id)
    {
        var activity = await context.Activities.FindAsync(id);
        if (activity == null)
        {
            return NotFound();
        }
        return Ok(activity);
    }
}