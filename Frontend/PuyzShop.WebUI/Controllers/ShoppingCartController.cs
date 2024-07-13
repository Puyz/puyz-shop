using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
