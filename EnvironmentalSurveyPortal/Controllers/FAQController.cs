using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalSurveyPortal.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
