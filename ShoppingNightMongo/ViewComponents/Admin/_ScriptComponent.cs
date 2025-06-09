using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.Admin
{
    public class _ScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
