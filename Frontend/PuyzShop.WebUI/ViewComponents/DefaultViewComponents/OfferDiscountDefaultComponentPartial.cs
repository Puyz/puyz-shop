using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class OfferDiscountDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
