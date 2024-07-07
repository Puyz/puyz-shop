using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.UILayoutViewComponent
{
    public class TopbarUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
