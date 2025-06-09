using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.Admin
{
    public class _SidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
