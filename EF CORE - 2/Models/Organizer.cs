
namespace EF_CORE___2.Models;

public class Organizer
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? CompanyName { get; set; }
    public bool IsVerified { get; set; }
    public DateTime? CreatedAt { get; set; }
    public OrganizerProfile OrganizerProfile { get; set; }
    public List<Event> Events { get; set; } = [];
}
