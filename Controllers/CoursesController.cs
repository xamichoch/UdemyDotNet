using System.Collections.Generic;
using CorsoDotnet.Models.Services.Application;
using CorsoDotnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorsoDotnet.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            CourseService courseService = new CourseService();
            List<CourseViewModel> courses = courseService.getServices();

            return View(courses);
        }

        public IActionResult Detail(string id)
        {
            return View();
        }

    }
}