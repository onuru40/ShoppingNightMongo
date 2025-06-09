using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.UI
{
    public class _UINavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
