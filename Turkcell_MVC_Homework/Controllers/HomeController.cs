using Microsoft.AspNetCore.Mvc;
using Turkcell_MVC_Homework.Models;

namespace Turkcell_MVC_Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Volunteer volunter)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
            return View("Error");
        }
        [HttpGet]
        public IActionResult Exit()
        {
            return View();
        }
    }
}
