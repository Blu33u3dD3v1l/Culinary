using Microsoft.AspNetCore.Mvc;

namespace Culinary.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Event()
        {
            return View();
        }
    }
}
