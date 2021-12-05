using AuthoringTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthoringTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(bool approved = false)
        {
            WebsiteContext model = new()
            {
                Approved = approved,
                CopyrightYear = 2015,
                Version = new Version(1, 3, 3, 7),
                TagsToShow = 20,
            };

            return View(model: model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = nameof(Contact);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = nameof(Contact);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}