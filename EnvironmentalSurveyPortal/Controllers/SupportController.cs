using EnvironmentalSurveyPortal.Data;
using EnvironmentalSurveyPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalSurveyPortal.Controllers
{
    public class SupportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SupportController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Support
        public IActionResult Index()
        {
            var support = _context.Support.ToList();
            return View(support);
        }

        // GET: Support/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Support/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Support support)
        {
            if (ModelState.IsValid)
            {
                _context.Support.Add(support);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(support);
        }
    }
}
