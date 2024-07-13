using Microsoft.AspNetCore.Mvc;

namespace PuyzShop.WebUI.ViewComponents.ContactViewComponents
{
    public class ContactDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
