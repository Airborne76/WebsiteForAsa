using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebsiteForAsa.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "Contact page.";
            return View();
        }

        public ActionResult Submit(string name,string company,string address,string city,string state,string zipCode,string email,string questions)
        {
            return View("Index");
        }
    }
}
