using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
