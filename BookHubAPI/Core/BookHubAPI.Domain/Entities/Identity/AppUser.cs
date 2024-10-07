using Microsoft.AspNetCore.Identity;

namespace BookHubAPI.Domain.Entities.Identity;

public class AppUser : IdentityUser<string>
{
    public string Fullname { get; set; }
}
