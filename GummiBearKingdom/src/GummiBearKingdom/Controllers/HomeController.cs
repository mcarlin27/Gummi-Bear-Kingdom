using Microsoft.AspNetCore.Mvc;

namespace GummiBearKingdom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
