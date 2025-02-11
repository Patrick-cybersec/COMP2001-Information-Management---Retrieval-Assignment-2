using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models{
public class AppUser
{
    [Key]
    [Required] 
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required] 
    [StringLength(50)] 
    public string FirstName { get; set; } = string.Empty;

    [Required] 
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Phone] 
    public string PhoneNumber { get; set; } = string.Empty;

    public string AboutMe { get; set; } = string.Empty;

    [Range(0, 300)] 
    public int Height { get; set; }

    [Range(0, 500)] 
    public int Weight { get; set; }

    [DataType(DataType.Date)] 
    public DateTime DOB { get; set; }

    [Required] 
    [MinLength(8)] 
    public string Password { get; set; } = string.Empty;}
}
