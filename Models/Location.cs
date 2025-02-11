using System.ComponentModel.DataAnnotations;

namespace ProfileService.Models{
public class Location
{
    [Key] 
    public int LocationId { get; set; }

    [Required] 
    [StringLength(100)] 
    public string LocationName { get; set; } = string.Empty;

    public Location(int locationId, string locationName)
    {
        LocationId = locationId;
        LocationName = locationName ?? throw new ArgumentNullException(nameof(locationName));
    }

    public Location() 
    {
        
    }}
}