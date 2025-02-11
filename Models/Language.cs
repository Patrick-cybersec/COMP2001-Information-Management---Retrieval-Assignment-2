using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models{
public class Language
{
    [Key] 
    public int LanguageId { get; set; }

    [Required]
    [StringLength(100)] 
    public string LanguageName { get; set; } = string.Empty;
}}