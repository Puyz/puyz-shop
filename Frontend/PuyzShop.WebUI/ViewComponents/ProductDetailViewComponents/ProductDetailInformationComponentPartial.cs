using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class ProductDetailInformationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
