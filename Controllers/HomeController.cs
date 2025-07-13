using Microsoft.AspNetCore.Mvc;

namespace LibraryInventoryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
} 