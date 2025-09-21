using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PatDay03View.Models;

namespace PatDay03View.Controllers
{
    public class PatHomeController : Controller
    {
        private readonly ILogger<PatHomeController> _logger;

        public PatHomeController(ILogger<PatHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PatIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PatAbout()
        {
            return View();
        }

        public IActionResult PatViewIf()
        {
            return View();
        }
        public IActionResult PatViewLoop()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
