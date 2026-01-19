using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EnvironmentalSurveyPortal.Models;

namespace EnvironmentalSurveyPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Survey> Surveys { get; set; }

        public DbSet<SurveyResponse> SurveyResponses { get; set; }

        public DbSet<Support> Support { get; set; }
    }
}
