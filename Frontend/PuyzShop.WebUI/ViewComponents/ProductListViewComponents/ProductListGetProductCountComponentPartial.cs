using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductListViewComponents
{
    public class ProductListGetProductCountComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
