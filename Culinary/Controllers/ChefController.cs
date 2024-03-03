using Microsoft.AspNetCore.Mvc;

namespace Culinary.Controllers
{
    public class ChefController : Controller
    {
        public IActionResult Chef()
        {
            return View();
        }
    }
}
