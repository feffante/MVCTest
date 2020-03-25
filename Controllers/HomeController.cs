using Microsoft.AspNetCore.Mvc;

namespace UDEMY.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}