using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductListViewComponents
{
    public class ProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
