using ShoppingNightMongo.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents.UI
{
    public class _UISliderComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _UISliderComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }
    }
}
