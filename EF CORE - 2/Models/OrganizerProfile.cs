
using Microsoft.EntityFrameworkCore;

namespace EF_CORE___2.Models;

[Owned]
public class OrganizerProfile
{
   
    public string Bio { get; set; } = null!;
    public string WebsiteUrl { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
}
