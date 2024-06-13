using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.LayoutViewComponents
{
    public class LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
