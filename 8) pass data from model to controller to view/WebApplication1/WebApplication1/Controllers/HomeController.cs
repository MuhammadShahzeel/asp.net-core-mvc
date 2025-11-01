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

            //// Create object of Employee and fill data
            //var employee = new Employee()
            //{
            //    Id = 1,
            //    Name = "Ali Ahmed",
            //    Department = "IT",
            //    Salary = 85000
            //};

            //ViewData["Employee"] = employee;
            // Create a list of Employees
            var employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ali Ahmed", Department = "IT", Salary = 85000 },
                new Employee { Id = 2, Name = "Sara Khan", Department = "HR", Salary = 72000 },
                new Employee { Id = 3, Name = "Bilal Hussain", Department = "Finance", Salary = 95000 },
                new Employee { Id = 4, Name = "Hina Raza", Department = "Marketing", Salary = 68000 }
            };

            //  Pass the list using ViewData
            ViewData["Employees"] = employees;
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
