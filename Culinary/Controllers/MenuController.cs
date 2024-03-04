using Microsoft.AspNetCore.Mvc;

namespace Culinary.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Salad()
        {
            return View();
        }

        public IActionResult Starter()
        {
            return View();
        }

        public IActionResult Specialty()
        {
            return View();
        }
    }
}
