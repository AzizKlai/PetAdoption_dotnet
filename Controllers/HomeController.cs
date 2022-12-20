using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetAdoption_dotnet.Models;

namespace PetAdoption_dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        
    }

    public IActionResult Index()
    {   // to get the absolute path of db
              string path = ".";
              string fullPath = Path.GetFullPath(path);
              Console.WriteLine(fullPath);
              // to get the absolute path of db
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
