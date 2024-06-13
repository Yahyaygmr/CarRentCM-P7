using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.LayoutViewComponents
{
    public class LayoutTestimonialsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
