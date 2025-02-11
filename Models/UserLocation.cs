using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models
{
    public class UserLocation
    {
        [Required]
        public required string Email { get; set; }
        public int LocationId { get; set; } 
    }
}