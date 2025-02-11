using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models
{
    public class UserLanguage
    {
        [Required]
        public required string Email { get; set; } 
        public int LanguageId { get; set; } 
    }
}