using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ProductListViewComponents
{
    public class ProductListPaginationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
