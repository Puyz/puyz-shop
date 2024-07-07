using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.UILayoutViewComponent
{
    public class HeadUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
