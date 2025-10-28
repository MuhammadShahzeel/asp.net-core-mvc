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
            // view data example
            ViewData["data1"] = "Programentor";
            ViewData["data2"] = 25;
            ViewData["data3"] = DateTime.Now.ToLongDateString();

            // Array
            string[] arr = { "C#", "ASP.NET Core", "Razor", "MVC" };
            ViewData["data4"] = arr;

            // List
            List<string> courses = new List<string> { "HTML", "CSS", "JavaScript", "SQL" };
            ViewData["data5"] = courses;

            return View();
        }

        public IActionResult About() {
            ViewBag.Message = "Your application description page.";
            //array example
            string[] topics = { "C#", "ASP.NET Core", "Razor", "MVC" };
            ViewBag.Topics = topics;
            //list example
            List<string> tools = new List<string> { "Visual Studio", "SQL Server", "Git", "Azure" };
            ViewBag.Tools = tools;
            ViewData["data4"] = 5;



            return View();
        }
        public IActionResult Contact() => View();
        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
