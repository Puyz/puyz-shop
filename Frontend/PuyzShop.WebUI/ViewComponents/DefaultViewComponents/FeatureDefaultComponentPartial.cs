using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
