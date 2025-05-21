using BrightMindsBackend.Data;
using BrightMindsBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrightMindsBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialsController : ControllerBase
    {             
        private readonly DataContext _context;

        public TestimonialsController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Testimonial>>> AddTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            await _context.SaveChangesAsync();

            return Ok(await _context.Testimonials.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Testimonial>>> GetAllTestimonials()
        {
            return Ok(await _context.Testimonials.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Testimonial>> GetTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return BadRequest("Testimonial not found.");
            }
            return Ok(testimonial);
        }

    }
}
