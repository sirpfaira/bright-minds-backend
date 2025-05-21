namespace BrightMindsBackend.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Message { get; set; } = string.Empty;
        public required string Designation { get; set; } = string.Empty;

    }
}
