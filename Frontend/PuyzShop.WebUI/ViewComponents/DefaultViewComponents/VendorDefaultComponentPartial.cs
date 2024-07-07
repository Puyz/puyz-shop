using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class VendorDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
