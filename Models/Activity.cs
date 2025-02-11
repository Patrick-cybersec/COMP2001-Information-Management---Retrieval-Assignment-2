using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models{
public class Activity
{
    [Key] 
    public int ActivitiesId { get; set; }

    [Required] 
    [StringLength(100)]
    public string Activities { get; set; } = string.Empty;
}}