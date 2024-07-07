using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.UILayoutViewComponents
{
    public class FooterUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
