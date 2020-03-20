using Microsoft.AspNetCore.Mvc;

namespace UDEMY.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("sono index");
        }
        public IActionResult Detail(string id)
        {
            return Content($"sono detail, ho ricevuto l'id {id}");
        }
    }
}