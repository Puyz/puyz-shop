using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }
    }
}
