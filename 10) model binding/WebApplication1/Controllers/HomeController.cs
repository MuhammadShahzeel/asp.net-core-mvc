using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(Employee employee)
        {


            return $"Name: {employee.Name}, Gender: {employee.Gender}, " +
                $"Marital Status: {employee.MaritalStatus}, Address: {employee.Address}";

            // you can actual store data to database use IActionResult instead of string

        }
        public IActionResult Contact()
        {
            return View();
        }
        public int ContactId(int id)
        {
            return id;
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
