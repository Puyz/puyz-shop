using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class FeatureProductDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
