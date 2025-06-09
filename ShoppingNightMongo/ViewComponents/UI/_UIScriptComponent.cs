using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.UI
{
    public class _UIScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
