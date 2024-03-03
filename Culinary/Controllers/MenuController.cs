using Microsoft.AspNetCore.Mvc;

namespace Culinary.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
    }
}
