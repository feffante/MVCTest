using System;
using System.Collections.Generic;
using UDEMY.Models.Enums;
using UDEMY.Models.ValueTypes;
using UDEMY.Models.ViewModels;

namespace UDEMY.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetServices()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for(int i = 1;i <= 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel
                {
                    id=i,
                    Title=$"Corso{i}",
                    CurrentPrice=new Money(Currency.EUR, price), 
                    FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                    Author="Nome Cognome",
                    Rating = rand.NextDouble() * 5.0,
                    ImagePath = "/logo.png"
                };
                courseList.Add(course);
            }
            return courseList;
        }
    }
}