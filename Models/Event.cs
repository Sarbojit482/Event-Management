using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTimeOffset StartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTimeOffset EndTime { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}
