namespace EnvironmentalSurveyPortal.Models
{
    public class SurveyResponse
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string UserId { get; set; } = string.Empty;

        public string Answer { get; set; } = string.Empty;

        public Survey Survey { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
