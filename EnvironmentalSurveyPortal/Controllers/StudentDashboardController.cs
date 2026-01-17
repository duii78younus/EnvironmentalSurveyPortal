using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalSurveyPortal.Controllers
{
    public class StudentDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
