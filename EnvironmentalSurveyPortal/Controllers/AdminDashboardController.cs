using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalSurveyPortal.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
