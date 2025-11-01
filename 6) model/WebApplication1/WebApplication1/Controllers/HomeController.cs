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

            var students = new List<StudentModel>
            {
                new StudentModel { RollNo = 1, Name = "Ali Khan", Gender = "Male", Grade = "A" },
                new StudentModel { RollNo = 2, Name = "Sara Ahmed", Gender = "Female", Grade = "B" },
                new StudentModel { RollNo = 3, Name = "Bilal Sheikh", Gender = "Male", Grade = "A+" },
                new StudentModel { RollNo = 4, Name = "Fatima Noor", Gender = "Female", Grade = "C" }
            };

            ViewBag.Students = students;
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
