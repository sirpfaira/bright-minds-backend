using BrightMindsBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace BrightMindsBackend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Testimonial> Testimonials => Set<Testimonial>();
    }
}
