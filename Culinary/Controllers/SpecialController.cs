using Microsoft.AspNetCore.Mvc;

namespace Culinary.Controllers
{
    public class SpecialController : Controller
    {
        public IActionResult Special()
        {
            return View();
        }
    }
}
