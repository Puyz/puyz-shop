using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.UILayoutViewComponent
{
    public class NavbarUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
