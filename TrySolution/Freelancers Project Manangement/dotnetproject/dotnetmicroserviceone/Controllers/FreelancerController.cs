using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetmicroserviceone.Models;

namespace dotnetmicroserviceone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        private readonly FreelancerDbContext _context;

        public FreelancerController(FreelancerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Freelancer>>> GetAllFreelancers()
        {
            var Freelancers = await _context.Freelancers.ToListAsync();
            return Ok(Freelancers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Freelancer>> GetFreelancerById(int id)
        {
            var Freelancer = await _context.Freelancers.FindAsync(id);

            if (Freelancer == null)
            {
                return NotFound();
            }

            return Ok(Freelancer);
        }
        [HttpPost]
        public async Task<ActionResult> AddFreelancer(Freelancer Freelancer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return detailed validation errors
            }
            await _context.Freelancers.AddAsync(Freelancer);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFreelancer(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid Freelancer id");

            var Freelancer = await _context.Freelancers.FindAsync(id);
              _context.Freelancers.Remove(Freelancer);
                await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
