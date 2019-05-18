using System;
using System.Collections.Generic;
using CorsoDotnet.Models.ViewModels;

namespace CorsoDotnet.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> getServices()
        {
            List<CourseViewModel> courses = new List<CourseViewModel>();

            for (var i = 0; i <= 20; i++)
            {
                CourseViewModel course = new CourseViewModel
                {
                    Id = 0,
                    Titolo = "Corso n°1",
                    Author = "Marco Chocho",
                    Rating = 3.2,
                    ImagePath = "/logo.svg",
                    FullPrice = new Money(Currency.RUB, (decimal)1200.58),
                    CurrentPrice = new Money(Currency.RUB, (decimal)990.00),
                };

                courses.Add(course);

            }

            return courses;

        }
    }
}