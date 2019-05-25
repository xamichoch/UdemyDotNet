using System.Collections.Generic;
using CorsoDotnet.Models.Services.Application;
using CorsoDotnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorsoDotnet.Controllers
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
            List<CourseViewModel> courses = courseService.GetCourses();
            return View(courses);
        }

        public IActionResult Detail(string id)
        {
            CourseDetailViewModel course = courseService.GetCourse(id);
            return View(course);
        }

    }

}