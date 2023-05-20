using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivitiesAsync()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Activity>> GetActivityAsync(int id)
        {
            Activity? activity = await _context.Activities.FindAsync(id);

            if (activity == null)
                return NotFound();

            return Ok(activity);
        }
    }
}