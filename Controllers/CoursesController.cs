using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UDEMY.Models.Services.Application;
using UDEMY.Models.ViewModels;

namespace UDEMY.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courseService = new CourseService();           
           List<CourseViewModel> courses =  courseService.GetServices();
            return View(courses);
        }
        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}