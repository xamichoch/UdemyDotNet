using System.Collections.Generic;
using CorsoDotnet.Models.ViewModels;

namespace CorsoDotnet.Models.Services.Application
{
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();

        CourseDetailViewModel GetCourse(string id);

    }
}