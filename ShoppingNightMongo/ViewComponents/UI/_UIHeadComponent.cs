using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.UI
{
    public class _UIHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
