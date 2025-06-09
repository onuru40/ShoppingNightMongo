using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.Admin
{
    public class _FooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
