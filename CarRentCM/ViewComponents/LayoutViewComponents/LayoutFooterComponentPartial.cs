using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.LayoutViewComponents
{
    public class LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
