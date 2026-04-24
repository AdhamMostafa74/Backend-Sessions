
namespace EF_CORE___2.Models;

public class Session
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int EventId { get; set; }
    public Event Event { get; set; }

}
