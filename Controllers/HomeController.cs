using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using PetAdoption_dotnet.Models;

namespace PetAdoption_dotnet.Controllers;
 [Authorize]
public class HomeController : Controller
{   private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {   
        _logger = logger;
        
    }
    [AllowAnonymous]
    public IActionResult Index()
    {    /*string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
    string query = "INSERT INTO vets( `name`, `adress`, `number`) VALUES ( 'a', 'a', 'aa')";
    // Which could be translated manually to :
    // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')
    
    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
    commandDatabase.CommandTimeout = 60;
    
    try
    {
        databaseConnection.Open();
        MySqlDataReader myReader = commandDatabase.ExecuteReader();
        
     
   
        databaseConnection.Close();
    }
    catch (Exception ex)
    {
        
    }*/
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
