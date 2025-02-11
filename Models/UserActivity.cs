using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models
{
    public class UserActivity
    {
        [Required] 
        public required string Email { get; set; } 
        public int ActivitiesId { get; set; } 
    }
}