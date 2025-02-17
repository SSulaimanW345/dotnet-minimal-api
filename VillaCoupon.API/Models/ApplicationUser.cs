using Microsoft.AspNetCore.Identity;

namespace VillaCoupon.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
