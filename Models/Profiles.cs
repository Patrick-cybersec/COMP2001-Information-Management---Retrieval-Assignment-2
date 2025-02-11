using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models{
public class Profile
{
    [Key] 
    public int Id { get; set; }

    [Required] 
    [StringLength(50)]
    public string UserName { get; set; } = string.Empty;

    [Required] 
    [EmailAddress] 
    public string Email { get; set; } = string.Empty;

    [Required] 
    [MinLength(8)] 
    public string Password { get; set; } = string.Empty;

    [Required] 
    public string Role { get; set; } = string.Empty;

    public bool IsArchived { get; set; } = false; 
}}