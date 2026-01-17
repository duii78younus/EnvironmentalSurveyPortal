using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalSurveyPortal.Controllers
{
    public class SurveyResponseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
