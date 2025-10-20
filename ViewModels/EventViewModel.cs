using EventManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required, DataType(DataType.DateTime)]
        public DateTimeOffset StartTime { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTimeOffset EndTime { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please select a venue")]
        public int VenueId { get; set; }

        public List<Venue> Venues { get; set; } = new List<Venue>();
    }
}
