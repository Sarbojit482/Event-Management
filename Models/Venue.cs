using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; } = string.Empty;

        public string? Address { get; set; }

        [Range(1, 10000)]
        public int Capacity { get; set; }

        public IList<Event> Events { get; set; } = new List<Event>();
    }
}
