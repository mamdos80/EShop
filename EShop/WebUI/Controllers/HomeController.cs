using Microsoft.AspNetCore.Mvc;

namespace EShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
