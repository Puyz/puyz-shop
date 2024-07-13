using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.UILayoutViewComponents
{
    public class ScriptUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
