using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductListViewComponents
{
    public class ProductListPriceFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
