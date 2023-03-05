using Microsoft.AspNetCore.Identity;

namespace PathTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserTimeSpent> UserTimeSpendings { get; set; }
    }
}
