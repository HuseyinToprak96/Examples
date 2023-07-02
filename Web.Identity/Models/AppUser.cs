using Microsoft.AspNetCore.Identity;

namespace Web.Identity.Models
{
    public class AppUser:IdentityUser
    {
        public string City { get; set; }
    }
}
