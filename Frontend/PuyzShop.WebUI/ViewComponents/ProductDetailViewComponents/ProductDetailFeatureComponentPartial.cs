using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class ProductDetailFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
