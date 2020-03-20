using Microsoft.AspNetCore.Mvc;

namespace UDEMY.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return Content("sono la index della home");
        }
    }
}