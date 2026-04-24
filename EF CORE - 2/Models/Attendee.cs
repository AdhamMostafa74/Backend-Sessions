
namespace EF_CORE___2.Models;

public class Attendee
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public Address Address { get; set; }
    public Badge? Badge { get; set; }
    public List<Registration> Registrations { get; set; } = [];
}
