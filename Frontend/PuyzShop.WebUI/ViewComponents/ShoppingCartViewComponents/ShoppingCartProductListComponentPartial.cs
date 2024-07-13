using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ShoppingCartViewComponents
{
    public class ShoppingCartProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
