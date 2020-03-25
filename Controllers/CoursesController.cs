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
            ViewData["Title"] = "Catalgo corsi";
            var courseService = new CourseService();           
           List<CourseViewModel> courses =  courseService.GetCourses();
            return View(courses);
        }
        public IActionResult Detail(int id)
        {
            var courseService = new CourseService();
            CourseDetailViewModel viewModel= courseService.GetCourse(id);
           ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }
    }
}