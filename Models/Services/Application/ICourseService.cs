using System.Collections.Generic;
using UDEMY.Models.ViewModels;

namespace UDEMY.Models.Services.Application
{
    public interface ICourseService
    {
         List<CourseViewModel> GetCourses();
         CourseDetailViewModel GetCourse(int Id);
    }
}