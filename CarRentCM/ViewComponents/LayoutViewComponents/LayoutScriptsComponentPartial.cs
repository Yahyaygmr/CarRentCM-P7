using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.LayoutViewComponents
{
    public class LayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
