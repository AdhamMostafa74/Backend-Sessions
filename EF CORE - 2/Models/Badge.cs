
using EF_CORE___2.Enums;

namespace EF_CORE___2.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
        public int BadgeNumber { get; set; }
        public DateTime IssuedDate{ get; set; }
        public Tier Tier { get; set; }
    }
}
