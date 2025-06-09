using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.Admin
{
    public class _NavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
