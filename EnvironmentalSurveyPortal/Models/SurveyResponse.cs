namespace EnvironmentalSurveyPortal.Models
{
    public class SurveyResponse
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string UserId { get; set; }

        public string Answer { get; set; }

        public Survey Survey { get; set; }
        public ApplicationUser User { get; set; }
    }
}
