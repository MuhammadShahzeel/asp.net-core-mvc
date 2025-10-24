using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult MyDashboard()
        {
            return View();
        }


        public int RouteWithId(int id)
        {
            //later we pass this id to view
            
            return id;
        }
    }
}
