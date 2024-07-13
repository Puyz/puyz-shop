using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class ProductDetailReviewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
