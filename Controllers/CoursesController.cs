using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UDEMY.Models.Services.Application;
using UDEMY.Models.ViewModels;

namespace UDEMY.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Catalgo corsi";
           List<CourseViewModel> courses =  courseService.GetCourses();
            return View(courses);
        }
        public IActionResult Detail(int id)
        {
            CourseDetailViewModel viewModel= courseService.GetCourse(id);
           ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }
    }
}