using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebsiteForAsa.Controllers
{
    public class CoursesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Dictionary<string, string> Courses = new Dictionary<string, string>()
            {
                {"ENVIRONMENT DESIGN","/images/Courses/1.png" },
                {"ADVANCED ENVIRONMENT DESIGN","/images/Courses/2.png" },
                {"CHARACTER DESIGN I","/images/Courses/3.png" },
                {"CHARACTER DESIGN II","/images/Courses/4.jpg" },
                {"FUNDAMENTALS OF CHARACTER DESIGN","/images/Courses/5.jpg" },
                {"WEAPONS & PROPS FOR GAMES","/images/Courses/6.png" },
                {"ENTERTAINMENT DEISGN","/images/Courses/7.png" },
                {"ADVANCED MENTORSHIP","/images/Courses/8.png" }
            };
            ViewData["list"] = Courses;
            return View();
        }
    }
}
