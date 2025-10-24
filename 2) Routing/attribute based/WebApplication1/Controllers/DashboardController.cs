using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    public class DashboardController : Controller
    {
        
        [Route("~/")]
        public IActionResult MyDashboard()
        {
            return View();
        }
        [Route("Home/View")]
        public IActionResult Home()
        {
            return View();
        }


        //pass specific view name
        //note home1 view does not exist but we are passing different view
        [Route("Home/abcd")]
        public IActionResult Home1()
        {
            return View("~/Views/Home/Index.cshtml");
        }


        //with id parameter
        [Route("Home/View/{id}")]
        public int RouteWithId(int id)
        {
            //later we pass this id to view

            return id;
        }

        //with optional id parameter
        [Route("Home/{id?}")]
        public int Optional(int id)
        {
            //later we pass this id to view

            return id;


           

        }
        // if id is optional pass defualt value 1
        [Route("search/{id?}")]
        public int Search(int? id)
        {
            return id ?? 1;
        }
    }
}
