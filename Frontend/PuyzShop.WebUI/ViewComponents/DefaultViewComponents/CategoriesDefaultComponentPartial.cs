using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class CategoriesDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
