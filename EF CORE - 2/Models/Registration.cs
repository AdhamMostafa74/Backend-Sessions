
namespace EF_CORE___2.Models;

public class Registration
{
    public int Id { get; set; }
    public int AttendeeId { get; set; }
    public Attendee Attendee { get; set; }
    public int EventId { get; set; }
    public Event Event { get; set; }
    public string? Note{ get; set; }
    public DateTime RegisteredAt { get; set; }
}
