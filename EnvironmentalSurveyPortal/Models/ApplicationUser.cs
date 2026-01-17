using Microsoft.AspNetCore.Identity;

namespace EnvironmentalSurveyPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
