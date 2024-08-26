using Callie.Areas.Identity.Data;
using Callie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Callie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CallieDbContext _callieDbContext;

        public HomeController(CallieDbContext callieDbContext, ILogger<HomeController> logger)
        {
            _callieDbContext = callieDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
