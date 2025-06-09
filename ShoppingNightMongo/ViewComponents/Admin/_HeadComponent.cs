using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.Admin
{
    public class _HeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
