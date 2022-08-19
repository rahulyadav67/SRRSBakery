using Microsoft.AspNetCore.Mvc;
using SRRSBakery.Models;
using SRRSBakery.ViewModels;
using System.Diagnostics;

namespace SRRSBakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      //  private readonly CategoryRepository _CategoryRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           // categoryRepository=_CategoryRepository;
           // _CategoryRepository = (CategoryRepository)categoryRepository;
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