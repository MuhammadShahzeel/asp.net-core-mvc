using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repo;

        public HomeController(ILogger<HomeController> logger,IRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }


        public List<StudentModel> GetStudents()
        {
            var students = _repo.GetAllStudents();
            return students;
            //pass this data to view
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
